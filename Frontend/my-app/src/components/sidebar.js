import { Navbar, Nav, Image } from "react-bootstrap";
import "../styles/sideBar.css";
import "bootstrap/dist/css/bootstrap.min.css";
import ArrowRight from "../components/arrowRight";
import image from "../photos/shoes.jpg";
import image2 from "../photos/shoes2.jpg";
import image3 from "../photos/shoes3.jpg";
import { useEffect, useState } from "react";
export default function SideBar() {
  const [currentPhoto, setcurrentPhoto] = useState(0);
  let opacity = 0;
  function ReduceOpacity() {
    setTimeout(() => {
      const opacityReducer = setInterval(() => {
        opacity = opacity - 0.005;
        document.querySelector("#photos").style.opacity = opacity;
        if (opacity < 0.001) {
          clearInterval(opacityReducer);
          InreaseOpacity();
          document.querySelector("#photos").src=image2
        }
      }, 7);
    }, 6000);
  }
  function InreaseOpacity() {
    const opacityIncrease = setInterval(() => {
      opacity = opacity + 0.005;
      document.querySelector("#photos").style.opacity = opacity;
      if (opacity > 1) {
        clearInterval(opacityIncrease);
        ReduceOpacity();
      }
    }, 7);
  }
  let positionX=-300
  function moveRight(){
    const moveRight=setInterval(()=>{
      positionX=positionX+2
      document.querySelector(".sideBar").style.left=positionX+"px"
      if(positionX===60){
        clearInterval(moveRight)
      }
    },1)
  }

useEffect(()=>{
  InreaseOpacity()
  moveRight()
},[])

  return (
    <>
      <main>
        <Navbar className="sideBar"
          style={{ width: "300px", maxHeight: "650px",position:"absolute",left:"-300px" }}
          bg="dark"
          variant="dark"
        >
          <Nav
            style={{ width: "150px", paddingLeft: "20px", display: "flex" }}
            className=" sideBar d-flex flex-column"
          >
            <Nav.Link className="category" href="#features">
              Football <ArrowRight />
            </Nav.Link>
            <Nav.Link className="category" href="#pricing">
              Basketball
              <ArrowRight />
            </Nav.Link>
            <Nav.Link className="category" href="#home">
              Fitness
              <ArrowRight />
            </Nav.Link>

            <Nav.Link className="category" href="#features">
              Football <ArrowRight />
            </Nav.Link>
            <Nav.Link className="category" href="#pricing">
              Basketball
              <ArrowRight />
            </Nav.Link>
            <Nav.Link className="category" href="#home">
              Fitness
              <ArrowRight />
            </Nav.Link>

            <Nav.Link className="category" href="#features">
              Football <ArrowRight />
            </Nav.Link>
            <Nav.Link className="category" href="#pricing">
              Basketball
              <ArrowRight />
            </Nav.Link>
            <Nav.Link className="category" href="#home">
              Fitness
              <ArrowRight />
            </Nav.Link>

            <Nav.Link className="category" href="#features">
              Football <ArrowRight />
            </Nav.Link>
            <Nav.Link className="category" href="#pricing">
              Basketball
              <ArrowRight />
            </Nav.Link>
            <Nav.Link className="category" href="#home">
              Fitness
              <ArrowRight />
            </Nav.Link>

            <Nav.Link className="category" href="#features">
              Football <ArrowRight />{" "}
            </Nav.Link>
            <Nav.Link className="category" href="#pricing">
              Basketball
              <ArrowRight />{" "}
            </Nav.Link>
            <Nav.Link className="category" href="#home">
              Fitness
              <ArrowRight />{" "}
            </Nav.Link>
          </Nav>
        </Navbar>

        <figure className="photos">
          <img
            id="photos"
            src={image}
            className="img-fluid"
            alt="Responsive image"
          ></img>
        </figure>
      </main>
    </>
  );
}
