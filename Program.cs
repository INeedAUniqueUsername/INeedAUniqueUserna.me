using HTMLSharp;
using System.Data.Common;
using System.Diagnostics;
// See https://aka.ms/new-console-template for more information
string url = "INeedAUniqueUserna.me";
HTML.Write("index.html", new(new(url,
    new(og_title: url, og_url: $"https://{url}", og_description: "aaaaaa"),
    new() {
        new("*",new(fontFamily:"Inconsolata")),
        new("h1", new(fontSize:"48px")),
        new("h2", new(fontSize:"30px")),
        new("p", new(fontSize:"24px")),
        new(".entry", new(border:"2px solid black", padding:"0px 32px 0px 32px", marginBottom:"16px"))
    },
    new() {

    }), new(style:new Style(backgroundColor: "black"), children: new() {
        new Div(style:new Style(backgroundColor:"white", padding:"60px", centerHorizontal:true, width: "800px", marginTop:"60px"),
            children: new() {
                new H1(text:"INeedAUniqueUsername", style: new(textAlign:"center")),
                new P(text:"I develop high-quality games and development tools using my favorite programming language, C#."),
                new H2(text:"My Work"),
                
                new Div(cl: "entry", style:new(backgroundImage:""), children:new(){
                    new H2(text:"Super Nostalgia Entertainment Syndrome"),
                    new P(text: "Endless survival space combat game")
                }),
                new Div(cl: "entry", style:new(backgroundImage:""), children:new(){
                    new H2(text:"LC-Sharp"),
                    new P(text: "Emulator toolkit for the LC-3 assembly language")
                }),
                new Div(cl: "entry", style:new(backgroundImage:""), children:new(){
                    new H2(text:"AnniVersaRy (AVR) Tetris"),
                    new P(text: "Full-featured implementation of Tetris in celebration of the 35th anniversary")
                }),
                new Div(cl: "entry", style:new(backgroundImage:""), children:new(){
                    new H2(text:"Transgenesis II"),
                    new P(text: "Smart XML editor for game data")
                }),
                new Div(cl: "entry", style:new(backgroundImage:""), children:new(){
                    new H2(text:"TDP Leaderboard"),
                    new P(text: "Scorekeeping server (with validation) for EFHIII's TDP (Top-Down Platformer)")
                }),
                new Div(cl: "entry", style:new(backgroundImage:""), children:new(){
                    new H2(text:"ASECII (ASCII Sprite Editing Console II)"),
                    new P(text: "Sprite painter for ASCII tiles using SadConsole's ColoredGlyph")
                }),
                new Div(cl: "entry", style:new(backgroundImage:""), children:new(){
                    new H2(text:"Piano Radio"),
                    new P(text: "MIDI piano on the internet")
                }),
                new Div(cl: "entry", style:new(backgroundImage:""), children:new(){
                    new H2(text:"SpaceInvariantFindReplace"),
                    new P(text: "Regex generator for replacing many irregularly indented blocks of code.")
                }),
                new Div(cl: "entry", style:new(backgroundImage:""), children:new(){
                    new H2(text:"Rogue Frontier"),
                    new P(text: "ASCII roguelite space adventure inspired by Transcendence")
                }),
                new Div(cl: "entry", style:new(backgroundImage:""), children:new(){
                    new H2(text:"HTMLSharp"),
                    new P(text: "HTML generator using C#")
                })
            })
        })));

Process.Start(new ProcessStartInfo(){
            FileName = "index.html",
            UseShellExecute = true
        });