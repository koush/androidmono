namespace javax.xml.xpath
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class XPathConstants : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected XPathConstants(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.FieldId _NUMBER7343;
		public static global::javax.xml.@namespace.QName NUMBER
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::javax.xml.xpath.XPathConstants.staticClass, _NUMBER7343)) as javax.xml.@namespace.QName;
			}
		}
		internal static global::MonoJavaBridge.FieldId _STRING7344;
		public static global::javax.xml.@namespace.QName STRING
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::javax.xml.xpath.XPathConstants.staticClass, _STRING7344)) as javax.xml.@namespace.QName;
			}
		}
		internal static global::MonoJavaBridge.FieldId _BOOLEAN7345;
		public static global::javax.xml.@namespace.QName BOOLEAN
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::javax.xml.xpath.XPathConstants.staticClass, _BOOLEAN7345)) as javax.xml.@namespace.QName;
			}
		}
		internal static global::MonoJavaBridge.FieldId _NODESET7346;
		public static global::javax.xml.@namespace.QName NODESET
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::javax.xml.xpath.XPathConstants.staticClass, _NODESET7346)) as javax.xml.@namespace.QName;
			}
		}
		internal static global::MonoJavaBridge.FieldId _NODE7347;
		public static global::javax.xml.@namespace.QName NODE
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::javax.xml.xpath.XPathConstants.staticClass, _NODE7347)) as javax.xml.@namespace.QName;
			}
		}
		public static global::java.lang.String DOM_OBJECT_MODEL
		{
			get
			{
				return "http://java.sun.com/jaxp/xpath/dom";
			}
		}
		static XPathConstants()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.xml.xpath.XPathConstants.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/xml/xpath/XPathConstants"));
			global::javax.xml.xpath.XPathConstants._NUMBER7343 = @__env.GetStaticFieldIDNoThrow(global::javax.xml.xpath.XPathConstants.staticClass, "NUMBER", "Ljavax/xml/namespace/QName;");
			global::javax.xml.xpath.XPathConstants._STRING7344 = @__env.GetStaticFieldIDNoThrow(global::javax.xml.xpath.XPathConstants.staticClass, "STRING", "Ljavax/xml/namespace/QName;");
			global::javax.xml.xpath.XPathConstants._BOOLEAN7345 = @__env.GetStaticFieldIDNoThrow(global::javax.xml.xpath.XPathConstants.staticClass, "BOOLEAN", "Ljavax/xml/namespace/QName;");
			global::javax.xml.xpath.XPathConstants._NODESET7346 = @__env.GetStaticFieldIDNoThrow(global::javax.xml.xpath.XPathConstants.staticClass, "NODESET", "Ljavax/xml/namespace/QName;");
			global::javax.xml.xpath.XPathConstants._NODE7347 = @__env.GetStaticFieldIDNoThrow(global::javax.xml.xpath.XPathConstants.staticClass, "NODE", "Ljavax/xml/namespace/QName;");
		}
		internal static void InitJNI()
		{
		}
	}
}
