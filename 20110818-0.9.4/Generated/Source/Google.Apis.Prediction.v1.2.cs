//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.5446
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Google.Apis.Prediction.v1_2.Data {
    using System;
    using System.Collections;
    using System.Collections.Generic;
    
    
    public class Input {
        
        private Input.InputData input;
        
        [Newtonsoft.Json.JsonPropertyAttribute("input")]
        public virtual Input.InputData InputValue {
            get {
                return this.input;
            }
            set {
                this.input = value;
            }
        }
        
        public class InputData {
            
            private IList<System.String> csvInstance;
            
            [Newtonsoft.Json.JsonPropertyAttribute("csvInstance")]
            public virtual IList<System.String> CsvInstance {
                get {
                    return this.csvInstance;
                }
                set {
                    this.csvInstance = value;
                }
            }
        }
    }
    
    public class Output : Google.Apis.Requests.IDirectResponseSchema {
        
        private string id;
        
        private string kind;
        
        private string outputLabel;
        
        private IList<Output.OutputMultiData> outputMulti;
        
        private System.Nullable<double> outputValue;
        
        private string selfLink;
        
        private Google.Apis.Requests.RequestError error;
        
        private string eTag;
        
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id {
            get {
                return this.id;
            }
            set {
                this.id = value;
            }
        }
        
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind {
            get {
                return this.kind;
            }
            set {
                this.kind = value;
            }
        }
        
        [Newtonsoft.Json.JsonPropertyAttribute("outputLabel")]
        public virtual string OutputLabel {
            get {
                return this.outputLabel;
            }
            set {
                this.outputLabel = value;
            }
        }
        
        [Newtonsoft.Json.JsonPropertyAttribute("outputMulti")]
        public virtual IList<Output.OutputMultiData> OutputMulti {
            get {
                return this.outputMulti;
            }
            set {
                this.outputMulti = value;
            }
        }
        
        [Newtonsoft.Json.JsonPropertyAttribute("outputValue")]
        public virtual System.Nullable<double> OutputValue {
            get {
                return this.outputValue;
            }
            set {
                this.outputValue = value;
            }
        }
        
        [Newtonsoft.Json.JsonPropertyAttribute("selfLink")]
        public virtual string SelfLink {
            get {
                return this.selfLink;
            }
            set {
                this.selfLink = value;
            }
        }
        
        [Newtonsoft.Json.JsonPropertyAttribute("error")]
        public virtual Google.Apis.Requests.RequestError Error {
            get {
                return this.error;
            }
            set {
                this.error = value;
            }
        }
        
        public virtual string ETag {
            get {
                return this.eTag;
            }
            set {
                this.eTag = value;
            }
        }
        
        public class OutputMultiData {
            
            private string label;
            
            private System.Nullable<double> score;
            
            [Newtonsoft.Json.JsonPropertyAttribute("label")]
            public virtual string Label {
                get {
                    return this.label;
                }
                set {
                    this.label = value;
                }
            }
            
            [Newtonsoft.Json.JsonPropertyAttribute("score")]
            public virtual System.Nullable<double> Score {
                get {
                    return this.score;
                }
                set {
                    this.score = value;
                }
            }
        }
    }
    
    public class Training : Google.Apis.Requests.IDirectResponseSchema {
        
        private string id;
        
        private string kind;
        
        private Training.ModelInfoData modelInfo;
        
        private string selfLink;
        
        private string trainingStatus;
        
        private Google.Apis.Requests.RequestError error;
        
        private string eTag;
        
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id {
            get {
                return this.id;
            }
            set {
                this.id = value;
            }
        }
        
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind {
            get {
                return this.kind;
            }
            set {
                this.kind = value;
            }
        }
        
        [Newtonsoft.Json.JsonPropertyAttribute("modelInfo")]
        public virtual Training.ModelInfoData ModelInfo {
            get {
                return this.modelInfo;
            }
            set {
                this.modelInfo = value;
            }
        }
        
        [Newtonsoft.Json.JsonPropertyAttribute("selfLink")]
        public virtual string SelfLink {
            get {
                return this.selfLink;
            }
            set {
                this.selfLink = value;
            }
        }
        
        [Newtonsoft.Json.JsonPropertyAttribute("trainingStatus")]
        public virtual string TrainingStatus {
            get {
                return this.trainingStatus;
            }
            set {
                this.trainingStatus = value;
            }
        }
        
        [Newtonsoft.Json.JsonPropertyAttribute("error")]
        public virtual Google.Apis.Requests.RequestError Error {
            get {
                return this.error;
            }
            set {
                this.error = value;
            }
        }
        
        public virtual string ETag {
            get {
                return this.eTag;
            }
            set {
                this.eTag = value;
            }
        }
        
        public class ModelInfoData {
            
            private System.Nullable<double> classificationAccuracy;
            
            private System.Nullable<double> meanSquaredError;
            
            private string modelType;
            
            [Newtonsoft.Json.JsonPropertyAttribute("classificationAccuracy")]
            public virtual System.Nullable<double> ClassificationAccuracy {
                get {
                    return this.classificationAccuracy;
                }
                set {
                    this.classificationAccuracy = value;
                }
            }
            
            [Newtonsoft.Json.JsonPropertyAttribute("meanSquaredError")]
            public virtual System.Nullable<double> MeanSquaredError {
                get {
                    return this.meanSquaredError;
                }
                set {
                    this.meanSquaredError = value;
                }
            }
            
            [Newtonsoft.Json.JsonPropertyAttribute("modelType")]
            public virtual string ModelType {
                get {
                    return this.modelType;
                }
                set {
                    this.modelType = value;
                }
            }
        }
    }
    
    public class Update {
        
        private string classLabel;
        
        private IList<System.String> csvInstance;
        
        /// <summary>The true class label of this instance</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("classLabel")]
        public virtual string ClassLabel {
            get {
                return this.classLabel;
            }
            set {
                this.classLabel = value;
            }
        }
        
        /// <summary>The input features for this instance</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("csvInstance")]
        public virtual IList<System.String> CsvInstance {
            get {
                return this.csvInstance;
            }
            set {
                this.csvInstance = value;
            }
        }
    }
}
namespace Google.Apis.Prediction.v1_2 {
    using System;
    using System.IO;
    using System.Collections.Generic;
    using Google.Apis;
    using Google.Apis.Discovery;
    
    
    public partial class PredictionService : Google.Apis.Discovery.IRequestProvider {
        
        private Google.Apis.Discovery.IService genericService;
        
        private Google.Apis.Authentication.IAuthenticator authenticator;
        
        private const string DiscoveryDocument = "{\"kind\":\"discovery#restDescription\",\"id\":\"prediction:v1.2\",\"name\":\"prediction\",\"v" +
            "ersion\":\"v1.2\",\"title\":\"Prediction API\",\"description\":\"Lets you access a cloud h" +
            "osted machine learning service that makes it easy to build smart apps\",\"icons\":{" +
            "\"x16\":\"http://www.google.com/images/icons/feature/predictionapi-16.png\",\"x32\":\"h" +
            "ttp://www.google.com/images/icons/feature/predictionapi-32.png\"},\"documentationL" +
            "ink\":\"http://code.google.com/apis/predict/docs/developer-guide.html\",\"labels\":[\"" +
            "labs\"],\"protocol\":\"rest\",\"basePath\":\"/prediction/v1.2/\",\"parameters\":{\"alt\":{\"ty" +
            "pe\":\"string\",\"description\":\"Data format for the response.\",\"default\":\"json\",\"enu" +
            "m\":[\"json\"],\"enumDescriptions\":[\"Responses with Content-Type of application/json" +
            "\"],\"location\":\"query\"},\"fields\":{\"type\":\"string\",\"description\":\"Selector specify" +
            "ing which fields to include in a partial response.\",\"location\":\"query\"},\"key\":{\"" +
            "type\":\"string\",\"description\":\"API key. Your API key identifies your project and " +
            "provides you with API access, quota, and reports. Required unless you provide an" +
            " OAuth 2.0 token.\",\"location\":\"query\"},\"oauth_token\":{\"type\":\"string\",\"descripti" +
            "on\":\"OAuth 2.0 token for the current user.\",\"location\":\"query\"},\"prettyPrint\":{\"" +
            "type\":\"boolean\",\"description\":\"Returns response with indentations and line break" +
            "s.\",\"default\":\"true\",\"location\":\"query\"},\"userIp\":{\"type\":\"string\",\"description\"" +
            ":\"IP address of the site where the request originates. Use this if you want to e" +
            "nforce per-user limits.\",\"location\":\"query\"}},\"auth\":{\"oauth2\":{\"scopes\":{\"https" +
            "://www.googleapis.com/auth/prediction\":{\"description\":\"Manage your data in the G" +
            "oogle Prediction API\"}}}},\"schemas\":{\"Input\":{\"id\":\"Input\",\"type\":\"object\",\"prop" +
            "erties\":{\"input\":{\"type\":\"object\",\"properties\":{\"csvInstance\":{\"type\":\"array\",\"i" +
            "tems\":{\"type\":\"any\"}}}}}},\"Output\":{\"id\":\"Output\",\"type\":\"object\",\"properties\":{" +
            "\"id\":{\"type\":\"string\"},\"kind\":{\"type\":\"string\",\"default\":\"prediction#output\"},\"o" +
            "utputLabel\":{\"type\":\"string\"},\"outputMulti\":{\"type\":\"array\",\"items\":{\"type\":\"obj" +
            "ect\",\"properties\":{\"label\":{\"type\":\"string\"},\"score\":{\"type\":\"number\",\"format\":\"" +
            "double\"}}}},\"outputValue\":{\"type\":\"number\",\"format\":\"double\"},\"selfLink\":{\"type\"" +
            ":\"string\"}}},\"Training\":{\"id\":\"Training\",\"type\":\"object\",\"properties\":{\"id\":{\"ty" +
            "pe\":\"string\"},\"kind\":{\"type\":\"string\",\"default\":\"prediction#training\"},\"modelInf" +
            "o\":{\"type\":\"object\",\"properties\":{\"classificationAccuracy\":{\"type\":\"number\",\"for" +
            "mat\":\"double\"},\"meanSquaredError\":{\"type\":\"number\",\"format\":\"double\"},\"modelType" +
            "\":{\"type\":\"string\"}}},\"selfLink\":{\"type\":\"string\"},\"trainingStatus\":{\"type\":\"str" +
            "ing\"}}},\"Update\":{\"id\":\"Update\",\"type\":\"object\",\"properties\":{\"classLabel\":{\"typ" +
            "e\":\"string\",\"description\":\"The true class label of this instance\"},\"csvInstance\"" +
            ":{\"type\":\"array\",\"description\":\"The input features for this instance\",\"items\":{\"" +
            "type\":\"any\"}}}}},\"methods\":{\"predict\":{\"id\":\"prediction.predict\",\"path\":\"trainin" +
            "g/{data}/predict\",\"httpMethod\":\"POST\",\"description\":\"Submit data and request a p" +
            "rediction\",\"parameters\":{\"data\":{\"type\":\"string\",\"description\":\"mybucket%2Fmydat" +
            "a resource in Google Storage\",\"required\":true,\"location\":\"path\"}},\"parameterOrde" +
            "r\":[\"data\"],\"request\":{\"$ref\":\"Input\"},\"response\":{\"$ref\":\"Output\"},\"scopes\":[\"h" +
            "ttps://www.googleapis.com/auth/prediction\"]}},\"resources\":{\"hostedmodels\":{\"meth" +
            "ods\":{\"predict\":{\"id\":\"prediction.hostedmodels.predict\",\"path\":\"hostedmodels/{ho" +
            "stedModelName}/predict\",\"httpMethod\":\"POST\",\"description\":\"Submit input and requ" +
            "est an output against a hosted model\",\"parameters\":{\"hostedModelName\":{\"type\":\"s" +
            "tring\",\"description\":\"The name of a hosted model\",\"required\":true,\"location\":\"pa" +
            "th\"}},\"parameterOrder\":[\"hostedModelName\"],\"request\":{\"$ref\":\"Input\"},\"response\"" +
            ":{\"$ref\":\"Output\"},\"scopes\":[\"https://www.googleapis.com/auth/prediction\"]}}},\"t" +
            "raining\":{\"methods\":{\"delete\":{\"id\":\"prediction.training.delete\",\"path\":\"trainin" +
            "g/{data}\",\"httpMethod\":\"DELETE\",\"description\":\"Delete a trained model\",\"paramete" +
            "rs\":{\"data\":{\"type\":\"string\",\"description\":\"mybucket%2Fmydata resource in Google" +
            " Storage\",\"required\":true,\"location\":\"path\"}},\"parameterOrder\":[\"data\"],\"scopes\"" +
            ":[\"https://www.googleapis.com/auth/prediction\"]},\"get\":{\"id\":\"prediction.trainin" +
            "g.get\",\"path\":\"training/{data}\",\"httpMethod\":\"GET\",\"description\":\"Check training" +
            " status of your model\",\"parameters\":{\"data\":{\"type\":\"string\",\"description\":\"mybu" +
            "cket%2Fmydata resource in Google Storage\",\"required\":true,\"location\":\"path\"}},\"p" +
            "arameterOrder\":[\"data\"],\"response\":{\"$ref\":\"Training\"},\"scopes\":[\"https://www.go" +
            "ogleapis.com/auth/prediction\"]},\"insert\":{\"id\":\"prediction.training.insert\",\"pat" +
            "h\":\"training\",\"httpMethod\":\"POST\",\"description\":\"Begin training your model\",\"par" +
            "ameters\":{\"data\":{\"type\":\"string\",\"description\":\"mybucket%2Fmydata resource in G" +
            "oogle Storage\",\"location\":\"query\"}},\"request\":{\"$ref\":\"Training\"},\"response\":{\"$" +
            "ref\":\"Training\"},\"scopes\":[\"https://www.googleapis.com/auth/prediction\"]},\"updat" +
            "e\":{\"id\":\"prediction.training.update\",\"path\":\"training/{data}\",\"httpMethod\":\"PUT" +
            "\",\"description\":\"Add new data to a trained model\",\"parameters\":{\"data\":{\"type\":\"" +
            "string\",\"required\":true,\"location\":\"path\"}},\"parameterOrder\":[\"data\"],\"request\":" +
            "{\"$ref\":\"Update\"},\"response\":{\"$ref\":\"Training\"},\"scopes\":[\"https://www.googleap" +
            "is.com/auth/prediction\"]}}}}}";
        
        private const string Version = "v1.2";
        
        private const string Name = "prediction";
        
        private const string BaseUri = "https://www.googleapis.com/prediction/v1.2/";
        
        private const Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;
        
        private string key;
        
        protected PredictionService(Google.Apis.Discovery.IService genericService, Google.Apis.Authentication.IAuthenticator authenticator) {
            this.genericService = genericService;
            this.authenticator = authenticator;
            this.hostedmodels = new HostedmodelsResource(this);
            this.training = new TrainingResource(this);
        }
        
        public PredictionService() : 
                this(Google.Apis.Authentication.NullAuthenticator.Instance) {
        }
        
        public PredictionService(Google.Apis.Authentication.IAuthenticator authenticator) : 
                this(new Google.Apis.Discovery.DiscoveryService(new Google.Apis.Discovery.StringDiscoveryDevice(DiscoveryDocument)).GetService(PredictionService.DiscoveryVersionUsed, new Google.Apis.Discovery.FactoryParameterV1_0(new System.Uri(PredictionService.BaseUri))), authenticator) {
        }
        
        /// <summary>Sets the API-Key (or DeveloperKey) which this service uses for all requests</summary>
        public virtual string Key {
            get {
                return this.key;
            }
            set {
                this.key = value;
            }
        }
        
        public virtual Google.Apis.Requests.IRequest CreateRequest(string resource, string method) {
            Google.Apis.Requests.IRequest request = this.genericService.CreateRequest(resource, method);
            if (!string.IsNullOrEmpty(Key)) {
                request = request.WithKey(this.Key);
            }
            return request.WithAuthentication(authenticator);
        }
        
        public virtual void RegisterSerializer(Google.Apis.ISerializer serializer) {
            genericService.Serializer = serializer;
        }
        
        public virtual string SerializeObject(object obj) {
            return genericService.SerializeRequest(obj);
        }
        
        public virtual T DeserializeResponse<T>(Google.Apis.Requests.IResponse response)
         {
            return genericService.DeserializeResponse<T>(response);
        }
        
        /// <summary>A list of all OAuth2.0 scopes. Each of these scopes relates to a permission or group of permissions that different methods of this API may need.</summary>
        public enum Scopes {
            
            /// <summary>Manage your data in the Google Prediction API</summary>
            [Google.Apis.Util.StringValueAttribute("https://www.googleapis.com/auth/prediction")]
            Prediction,
        }
    }
    
    public class HostedmodelsResource {
        
        private Google.Apis.Discovery.IRequestProvider service;
        
        private const string Resource = "hostedmodels";
        
        public HostedmodelsResource(PredictionService service) {
            this.service = service;
        }
        
        /// <summary>Submit input and request an output against a hosted model</summary>
        /// <param name="hostedModelName">Required - The name of a hosted model</param>
        public virtual PredictRequest Predict(Google.Apis.Prediction.v1_2.Data.Input body, string hostedModelName) {
            return new PredictRequest(service, body, hostedModelName);
        }
        
        public class PredictRequest : Google.Apis.Requests.ServiceRequest<Google.Apis.Prediction.v1_2.Data.Output> {
            
            private string hostedModelName;
            
            private Google.Apis.Prediction.v1_2.Data.Input bodyValue;
            
            public PredictRequest(Google.Apis.Discovery.IRequestProvider service, Google.Apis.Prediction.v1_2.Data.Input body, string hostedModelName) : 
                    base(service) {
                this.Body = body;
                this.hostedModelName = hostedModelName;
            }
            
            /// <summary>The name of a hosted model</summary>
            [Google.Apis.Util.RequestParameterAttribute("hostedModelName")]
            public virtual string HostedModelName {
                get {
                    return this.hostedModelName;
                }
            }
            
            /// <summary>Gets/Sets the Body of this Request.</summary>
            public virtual Google.Apis.Prediction.v1_2.Data.Input Body {
                get {
                    return this.bodyValue;
                }
                set {
                    this.bodyValue = value;
                }
            }
            
            protected override string ResourcePath {
                get {
                    return "hostedmodels";
                }
            }
            
            protected override string MethodName {
                get {
                    return "predict";
                }
            }
            
            protected override object GetBody() {
                return this.Body;
            }
        }
    }
    
    public class TrainingResource {
        
        private Google.Apis.Discovery.IRequestProvider service;
        
        private const string Resource = "training";
        
        public TrainingResource(PredictionService service) {
            this.service = service;
        }
        
        /// <summary>Delete a trained model</summary>
        /// <param name="data">Required - mybucket%2Fmydata resource in Google Storage</param>
        public virtual DeleteRequest Delete(string data) {
            return new DeleteRequest(service, data);
        }
        
        /// <summary>Check training status of your model</summary>
        /// <param name="data">Required - mybucket%2Fmydata resource in Google Storage</param>
        public virtual GetRequest Get(string data) {
            return new GetRequest(service, data);
        }
        
        /// <summary>Begin training your model</summary>
        public virtual InsertRequest Insert(Google.Apis.Prediction.v1_2.Data.Training body) {
            return new InsertRequest(service, body);
        }
        
        /// <summary>Add new data to a trained model</summary>
        /// <param name="data">Required</param>
        public virtual UpdateRequest Update(Google.Apis.Prediction.v1_2.Data.Update body, string data) {
            return new UpdateRequest(service, body, data);
        }
        
        public class DeleteRequest : Google.Apis.Requests.ServiceRequest<string> {
            
            private string data;
            
            public DeleteRequest(Google.Apis.Discovery.IRequestProvider service, string data) : 
                    base(service) {
                this.data = data;
            }
            
            /// <summary>mybucket%2Fmydata resource in Google Storage</summary>
            [Google.Apis.Util.RequestParameterAttribute("data")]
            public virtual string Data {
                get {
                    return this.data;
                }
            }
            
            protected override string ResourcePath {
                get {
                    return "training";
                }
            }
            
            protected override string MethodName {
                get {
                    return "delete";
                }
            }
        }
        
        public class GetRequest : Google.Apis.Requests.ServiceRequest<Google.Apis.Prediction.v1_2.Data.Training> {
            
            private string data;
            
            public GetRequest(Google.Apis.Discovery.IRequestProvider service, string data) : 
                    base(service) {
                this.data = data;
            }
            
            /// <summary>mybucket%2Fmydata resource in Google Storage</summary>
            [Google.Apis.Util.RequestParameterAttribute("data")]
            public virtual string Data {
                get {
                    return this.data;
                }
            }
            
            protected override string ResourcePath {
                get {
                    return "training";
                }
            }
            
            protected override string MethodName {
                get {
                    return "get";
                }
            }
        }
        
        public class InsertRequest : Google.Apis.Requests.ServiceRequest<Google.Apis.Prediction.v1_2.Data.Training> {
            
            private string data;
            
            private Google.Apis.Prediction.v1_2.Data.Training bodyValue;
            
            public InsertRequest(Google.Apis.Discovery.IRequestProvider service, Google.Apis.Prediction.v1_2.Data.Training body) : 
                    base(service) {
                this.Body = body;
            }
            
            /// <summary>mybucket%2Fmydata resource in Google Storage</summary>
            [Google.Apis.Util.RequestParameterAttribute("data")]
            public virtual string Data {
                get {
                    return this.data;
                }
                set {
                    this.data = value;
                }
            }
            
            /// <summary>Gets/Sets the Body of this Request.</summary>
            public virtual Google.Apis.Prediction.v1_2.Data.Training Body {
                get {
                    return this.bodyValue;
                }
                set {
                    this.bodyValue = value;
                }
            }
            
            protected override string ResourcePath {
                get {
                    return "training";
                }
            }
            
            protected override string MethodName {
                get {
                    return "insert";
                }
            }
            
            protected override object GetBody() {
                return this.Body;
            }
        }
        
        public class UpdateRequest : Google.Apis.Requests.ServiceRequest<Google.Apis.Prediction.v1_2.Data.Training> {
            
            private string data;
            
            private Google.Apis.Prediction.v1_2.Data.Update bodyValue;
            
            public UpdateRequest(Google.Apis.Discovery.IRequestProvider service, Google.Apis.Prediction.v1_2.Data.Update body, string data) : 
                    base(service) {
                this.Body = body;
                this.data = data;
            }
            
            [Google.Apis.Util.RequestParameterAttribute("data")]
            public virtual string Data {
                get {
                    return this.data;
                }
            }
            
            /// <summary>Gets/Sets the Body of this Request.</summary>
            public virtual Google.Apis.Prediction.v1_2.Data.Update Body {
                get {
                    return this.bodyValue;
                }
                set {
                    this.bodyValue = value;
                }
            }
            
            protected override string ResourcePath {
                get {
                    return "training";
                }
            }
            
            protected override string MethodName {
                get {
                    return "update";
                }
            }
            
            protected override object GetBody() {
                return this.Body;
            }
        }
    }
    
    public partial class PredictionService {
        
        private const string Resource = "";
        
        private HostedmodelsResource hostedmodels;
        
        private TrainingResource training;
        
        private Google.Apis.Discovery.IRequestProvider service {
            get {
                return this;
            }
        }
        
        public virtual HostedmodelsResource Hostedmodels {
            get {
                return this.hostedmodels;
            }
        }
        
        public virtual TrainingResource Training {
            get {
                return this.training;
            }
        }
        
        /// <summary>Submit data and request a prediction</summary>
        /// <param name="data">Required - mybucket%2Fmydata resource in Google Storage</param>
        public virtual PredictRequest Predict(Google.Apis.Prediction.v1_2.Data.Input body, string data) {
            return new PredictRequest(service, body, data);
        }
        
        public class PredictRequest : Google.Apis.Requests.ServiceRequest<Google.Apis.Prediction.v1_2.Data.Output> {
            
            private string data;
            
            private Google.Apis.Prediction.v1_2.Data.Input bodyValue;
            
            public PredictRequest(Google.Apis.Discovery.IRequestProvider service, Google.Apis.Prediction.v1_2.Data.Input body, string data) : 
                    base(service) {
                this.Body = body;
                this.data = data;
            }
            
            /// <summary>mybucket%2Fmydata resource in Google Storage</summary>
            [Google.Apis.Util.RequestParameterAttribute("data")]
            public virtual string Data {
                get {
                    return this.data;
                }
            }
            
            /// <summary>Gets/Sets the Body of this Request.</summary>
            public virtual Google.Apis.Prediction.v1_2.Data.Input Body {
                get {
                    return this.bodyValue;
                }
                set {
                    this.bodyValue = value;
                }
            }
            
            protected override string ResourcePath {
                get {
                    return "";
                }
            }
            
            protected override string MethodName {
                get {
                    return "predict";
                }
            }
            
            protected override object GetBody() {
                return this.Body;
            }
        }
    }
}
