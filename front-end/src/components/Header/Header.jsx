import React, { useRef } from "react";
import { Container } from "reactstrap";
import { Link, animateScroll as scroll } from "react-scroll";

import "./header.css";
const navLinks = [
  {
    display: "Home",
    url: "#Hero",
  },
  {
    display: "About",
    url: "#About",
  },

  {
    display: "Courses",
    url: "#Courses",
  },
];

const Header = () => {
  const menuRef = useRef();

  const menuToggle = () => menuRef.current.classList.toggle("active__menu");

  return (
    <header className="header">
      <Container>
        <div className="navigation d-flex align-items-center justify-content-between">
          <div className="logo">
            <h2 className=" d-flex align-items-center gap-1">
              <i class="ri-pantone-line"></i> track-n-learn
            </h2>
          </div>

          <div className="nav d-flex align-items-center gap-5">
            <div className="nav__menu" ref={menuRef} onClick={menuToggle}>
              <ul className="nav__list">
                {navLinks.map((item, index) => (
                  <li key={index} className="nav__item">
                    <Link className="nav__item" to={item.url} duration={10}>
                      {item.display}
                    </Link>
                  </li>
                ))}
              </ul>
            </div>
          </div>

          <div className="mobile__menu">
            <span>
              <i class="ri-menu-line" onClick={menuToggle}></i>
            </span>
          </div>
        </div>
      </Container>
    </header>
  );
};

export default Header;
