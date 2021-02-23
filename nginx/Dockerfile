FROM nginx:alpine

COPY nginx.conf /etc/nginx/
COPY geo.conf /etc/nginx/
COPY ./images/ /etc/nginx/images

#RUN apk add curl

EXPOSE 80 81 443
