import React from "react";
import { Container, Row, Col } from "reactstrap";
import "./features.css";

const FeatureData = [
  {
    title: "Quick Learning",
    desc: "Our courses are designed for quick learning, with concise and targeted lessons that maximize your time and retention.",
    icon: "ri-draft-line",
  },

  {
    title: "All Time Support",
    desc: "Our team here, is always available to hear from you for website or course content issues to provide you all the support you need.",
    icon: "ri-discuss-line",
  },

  {
    title: "Certification",
    desc: "One more advantage of taking courses, is once you complete a course you can also generate a certificate, which is useful while seaching for places to put your skills in use.",
    icon: "ri-contacts-book-line",
  },
];

const Features = () => {
  return (
    <section>
      <Container>
        <Row>
          {FeatureData.map((item, index) => (
            <Col lg="4" md="6" key={index}>
              <div className="single__feature text-center px-4">
                <h2 className="mb-3">
                  <i class={item.icon}></i>
                </h2>
                <h6>{item.title}</h6>
                <p>{item.desc}</p>
              </div>
            </Col>
          ))}
        </Row>
      </Container>
    </section>
  );
};

export default Features;
