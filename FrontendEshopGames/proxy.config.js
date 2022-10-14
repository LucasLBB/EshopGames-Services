const proxy = [
    {
      context: '/api',
      target: 'http://localhost:5246',
      pathRewrite: {'^/api' : ''}
    }
  ];
  module.exports = proxy;
