import {Navbar,Nav,Form,FormControl,Button} from 'react-bootstrap'
import 'bootstrap/dist/css/bootstrap.min.css'
import { useEffect } from 'react';
export default function NavBar() {
  let positionY=-55
  function  moveDown(){
   const moveDown = setInterval(()=>{
      positionY=positionY+1
      document.querySelector(".navBar").style.top=positionY + "px"
      if(positionY==0){
        clearInterval(moveDown)
      }
    },10)
  }
  useEffect(()=>{
      moveDown()
  },[])
    return <>
       <Navbar className="navBar"style={{position:"absolute", width:"100vw",top:"-55px"}} bg="dark" variant="dark">
    <Navbar.Brand href="#home">Navbar</Navbar.Brand>
    <Nav className="mr-auto">
      <Nav.Link href="#home">Home</Nav.Link>
      <Nav.Link href="#features">Features</Nav.Link>
      <Nav.Link href="#pricing">Pricing</Nav.Link>
    </Nav>
    <Form inline>
      <FormControl type="text" placeholder="Search" className="mr-sm-2" />
      <Button variant="outline-info">Search</Button>
    </Form>
  </Navbar>
    </>;
  }
  