using System.Xml.Serialization;
using HTMLSharp;
using static HTMLSharp.E;
using System.Data.Common;
using System.Diagnostics;
using X = System.Xml.Linq.XElement;
// See https://aka.ms/new-console-template for more information
var address = "INeedAUniqueUserna.me";
var github = "https://github.com/INeedAUniqueUsername";
X bgDiv(string imgSrc) =>
    div(style:new(backgroundImage: url(imgSrc), backgroundPosition:"50% 50%", backgroundSize:"cover"));
string url(string s) => @$"url({s})";
var stylePath = "style.css";
File.WriteAllText(stylePath, new Styleset(
    new(".empty",new(backgroundColor:"black")),
    new("*",new(fontFamily:"Inconsolata")),
    new("h1", new(fontSize:"60px")),
    new("h2", new(fontSize:"30px")),
    new("p", new(fontSize:"24px")),
    new(".entry", new(width: "572px", height: "192px", border:"2px solid black", padding:"0px 32px 0px 32px", marginBottom:"16px", backgroundColor:"rgb(255, 255, 255)")),
    new("a:link, a:visited", new(textDecoration:"inherit", color:"inherit")),
    new(".imgLink:hover *", new(color:"transparent", backgroundColor:"transparent")),
    new(".invert:hover *", new(color:"white", backgroundColor:"black"))
    //new("#snes:hover", new(backgroundImage: url("SNES.png"), backgroundPosition:"50% 50%", backgroundSize:"cover"))
).text);
var links = new List<Link>() {
    new(rel:"preconnect", href:"https://fonts.gstatic.com"),
    new(rel:"stylesheet", href: "https://fonts.googleapis.com/css2?family=Inconsolata&display=swap"),
    new(rel:"stylesheet", href: stylePath)
};
var indexPath = E.page("index.html", E.html(new(address,
    new(og_title: $"{address} - Index", og_image:$"https://{address}/Profile.png", og_url: $"https://{address}", og_description: "Home page of INeedAUniqeUserna.me"),
    null,
    links), new(style:new(backgroundImage: null /* "url(back.png)" */, margin: "0px"), content: new[] {
            div(style:new(backgroundColor:"white", padding:"60px", centerHorizontal:true, width: "640px"),
                content: new[] {
                    h1(content:"INeedAUniqueUsername", style: new(textAlign:"center")),
                    
                    div(style:new(margin:"0px 32px 0px 32px"), content:new[] {
                        p(content:"I create unique, high-quality games and development tools using my favorite technologies - specifically C# + .NET 6.0 + MonoGame + SadConsole."),
                        h2(style:new(textAlign:"center"), content:"My Work"),
                    }),

                    E.div(id: "snes", cl: "entry", content:new[]{
                        h2(content:"Super Nostalgia Entertainment Syndrome"),
                        p(content: "Endless survival space combat game")
                    }).Parent(a(cl:"imgLink", href:$"{github}/Super-Nostalgia-Entertainment-Syndrome"))
                        .Parent(bgDiv("SNES.png")),
                    
                    div(cl: "entry", content:new[]{
                        h2(content:"LC-Sharp"),
                        p(content: "Emulator toolkit for the LC-3 assembly language")
                    }).Parent(a(cl:"imgLink", href:$"{github}/LC-Sharp"))
                        .Parent(bgDiv("LC-Sharp.png")),
                    
                    div(cl: "entry", content:new[]{
                        h2(content:"AnniVersaRy (AVR) Tetris"),
                        p(content: "Full-featured implementation of Tetris in celebration of the 35th anniversary")
                    }).Parent(a(cl:"invert", href:$"{github}/CS120B/blob/master/achen115_project/achen115_project/main.c")),
                    
                    div(cl: "entry", content:new[]{
                        h2(content:"Transgenesis II"),
                        p(content: "Smart XML editor for game data")
                    }).Parent(a(cl:"invert", href:$"{github}/Transgenesis-II")),

                    div(cl: "entry", content:new[]{
                        h2(content:"TDP Leaderboard"),
                        p(content: "Scorekeeping server (with validation) for EFHIII's TDP (Top-Down Platformer)")
                    }).Parent(a(cl:"invert",href:$"{github}/TDP-Leaderboard")),

                    div(cl: "entry", content:new[]{
                        h2(content:"MIDI-Frame"),
                        p(content: "MIDI piano visualizer that generates video frames by applying color fill on a template image according to which notes are currently pressed.")
                    }).Parent(a(cl:"invert",href:$"{github}/MIDI-Frame")),
                    
                    div(cl: "entry", content:new[]{
                        h2(content:"ASECII (ASCII Sprite Editing Console II)"),
                        p(content: "Sprite painter for ASCII tiles using SadConsole's ColoredGlyph")
                    }).Parent(a(cl:"invert", href:$"{github}/ASECII")),
                    
                    div(cl: "entry", content:new[]{
                        h2(content:"Piano Radio"),
                        p(content: "MIDI piano on the internet (for Citrus Hack 2021)")
                    }).Parent(a(cl:"imgLink", href:$"{github}/PianoRadio"))
                        .Parent(div(style:new(backgroundImage: url("PianoRadio.png"), backgroundPosition:"50% 0%", backgroundSize:"cover"))),
                    
                    div(cl: "entry", content:new[]{
                        h2(content:"SpaceInvariantFindReplace"),
                        p(content: "Regex generator for replacing many irregularly indented blocks of code.")
                    }).Parent(a(cl:"invert", href:$"{github}/SpaceInvariantFindReplace")),
                    
                    div(cl: "entry", content:new[]{
                        h2(content:"Rogue Frontier"),
                        p(content: "ASCII roguelite space adventure inspired by Transcendence")
                    }).Parent(a(cl:"invert", href:$"{github}/Roguelikes/tree/master/RogueFrontier")),

                    div(cl: "entry", content:new[]{
                        h2(content:"HTMLSharp"),
                        p(content: "HTML generator using C#")
                    }).Parent(a(cl:"invert", href:$"{github}/HTMLSharp"))
                })
            })));
Process.Start(new ProcessStartInfo(){
            FileName = "index.html",
            UseShellExecute = true
        });