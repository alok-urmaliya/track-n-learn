import React from "react";
import { Container, Row, Col } from "reactstrap";
import courseImg1 from "../../assests/images/javascipt_tute_img.png";
import courseImg2 from "../../assests/images/csharp_tute_img.jpg";
import courseImg3 from "../../assests/images/python_tute_img.jpg";
import courseImg4 from "../../assests/images/cpp_tute_logo.jpg";
import "./courses.css";
import CourseCard from "./CourseCard";

const coursesData = [
  {
    id: "01",
    title: "JavaScript",
    lesson: 15,
    students: 12.5,
    rating: 4.9,
    imgUrl: courseImg1,
    route: "javascript",
  },

  {
    id: "02",
    title: "Csharp",
    lesson: 15,
    students: 12.5,
    rating: 4.5,
    imgUrl: courseImg2,
    route: "csharp",
  },

  {
    id: "03",
    title: "Python ",
    lesson: 15,
    students: 12.5,
    rating: 4.5,
    imgUrl: courseImg3,
    route: "python",
  },
  {
    id: "05 ",
    title: "C++",
    lesson: 15,
    students: 12.5,
    rating: 4.3,
    imgUrl: courseImg4,
    route: "cpp",
  },
];

const Courses = () => {
  return (
    <section id="#Courses">
      <Container>
        <Row>
          <Col lg="12" className="mb-5">
            <div className="course__top d-flex justify-content-between align-items-center">
              <div className="course__top__left w-50">
                <h2>Our Popular Courses</h2>
                <p>
                  We have provided a complete beginner guide for four of most
                  widely used programming languages till now, and are constantly
                  working in order to provide you more.
                </p>
              </div>
            </div>
          </Col>
          {coursesData.map((item) => (
            <Col lg="4" md="6" sm="6">
              <CourseCard key={item.id} route={item.url} item={item} />
            </Col>
          ))}
        </Row>
      </Container>
    </section>
  );
};

export default Courses;
