CREATE DATABASE IF NOT EXISTS minify;
USE minify;
CREATE TABLE IF NOT EXISTS mapping (
    id BIGINT NOT NULL AUTO_INCREMENT,
    short VARCHAR(32) NOT NULL UNIQUE,
    full_url VARCHAR(1024) NOT NULL,
    PRIMARY KEY (id)
);
