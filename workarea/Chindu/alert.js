// class is a template
class RailwayForm{
    submit(){
        alert("form submitted")
    }
    cancel(){
        alert("this form is cancelled")
    }
}

let teja = new RailwayForm()
let manu = new RailwayForm()

teja.submit()
manu.submit()
manu.cancel()