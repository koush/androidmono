namespace javax.xml.transform
{
	[global::MonoJavaBridge.JavaClass(typeof(global::javax.xml.transform.Transformer_))]
	public abstract partial class Transformer : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected Transformer(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public abstract void transform(javax.xml.transform.Source arg0, javax.xml.transform.Result arg1);
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual void reset()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.xml.transform.Transformer.staticClass, "reset", "()V", ref global::javax.xml.transform.Transformer._m1);
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public abstract void setParameter(java.lang.String arg0, java.lang.Object arg1);
		private static global::MonoJavaBridge.MethodId _m3;
		public abstract global::java.lang.Object getParameter(java.lang.String arg0);
		private static global::MonoJavaBridge.MethodId _m4;
		public abstract void clearParameters();
		private static global::MonoJavaBridge.MethodId _m5;
		public abstract global::java.util.Properties getOutputProperties();
		private static global::MonoJavaBridge.MethodId _m6;
		public abstract void setURIResolver(javax.xml.transform.URIResolver arg0);
		private static global::MonoJavaBridge.MethodId _m7;
		public abstract global::javax.xml.transform.URIResolver getURIResolver();
		private static global::MonoJavaBridge.MethodId _m8;
		public abstract void setOutputProperties(java.util.Properties arg0);
		private static global::MonoJavaBridge.MethodId _m9;
		public abstract void setOutputProperty(java.lang.String arg0, java.lang.String arg1);
		private static global::MonoJavaBridge.MethodId _m10;
		public abstract global::java.lang.String getOutputProperty(java.lang.String arg0);
		private static global::MonoJavaBridge.MethodId _m11;
		public abstract void setErrorListener(javax.xml.transform.ErrorListener arg0);
		private static global::MonoJavaBridge.MethodId _m12;
		public abstract global::javax.xml.transform.ErrorListener getErrorListener();
		private static global::MonoJavaBridge.MethodId _m13;
		protected Transformer() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.xml.transform.Transformer._m13.native == global::System.IntPtr.Zero)
				global::javax.xml.transform.Transformer._m13 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.Transformer.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.xml.transform.Transformer.staticClass, global::javax.xml.transform.Transformer._m13);
			Init(@__env, handle);
		}
		static Transformer()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.xml.transform.Transformer.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/xml/transform/Transformer"));
		}
		internal static void InitJNI()
		{
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::javax.xml.transform.Transformer))]
	internal sealed partial class Transformer_ : javax.xml.transform.Transformer
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal Transformer_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override void transform(javax.xml.transform.Source arg0, javax.xml.transform.Result arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.xml.transform.Transformer_.staticClass, "transform", "(Ljavax/xml/transform/Source;Ljavax/xml/transform/Result;)V", ref global::javax.xml.transform.Transformer_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override void setParameter(java.lang.String arg0, java.lang.Object arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.xml.transform.Transformer_.staticClass, "setParameter", "(Ljava/lang/String;Ljava/lang/Object;)V", ref global::javax.xml.transform.Transformer_._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public override global::java.lang.Object getParameter(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::javax.xml.transform.Transformer_.staticClass, "getParameter", "(Ljava/lang/String;)Ljava/lang/Object;", ref global::javax.xml.transform.Transformer_._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public override void clearParameters()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.xml.transform.Transformer_.staticClass, "clearParameters", "()V", ref global::javax.xml.transform.Transformer_._m3);
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public override global::java.util.Properties getOutputProperties()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::javax.xml.transform.Transformer_.staticClass, "getOutputProperties", "()Ljava/util/Properties;", ref global::javax.xml.transform.Transformer_._m4) as java.util.Properties;
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public override void setURIResolver(javax.xml.transform.URIResolver arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.xml.transform.Transformer_.staticClass, "setURIResolver", "(Ljavax/xml/transform/URIResolver;)V", ref global::javax.xml.transform.Transformer_._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public override global::javax.xml.transform.URIResolver getURIResolver()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<javax.xml.transform.URIResolver>(this, global::javax.xml.transform.Transformer_.staticClass, "getURIResolver", "()Ljavax/xml/transform/URIResolver;", ref global::javax.xml.transform.Transformer_._m6) as javax.xml.transform.URIResolver;
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public override void setOutputProperties(java.util.Properties arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.xml.transform.Transformer_.staticClass, "setOutputProperties", "(Ljava/util/Properties;)V", ref global::javax.xml.transform.Transformer_._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public override void setOutputProperty(java.lang.String arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.xml.transform.Transformer_.staticClass, "setOutputProperty", "(Ljava/lang/String;Ljava/lang/String;)V", ref global::javax.xml.transform.Transformer_._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public override global::java.lang.String getOutputProperty(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::javax.xml.transform.Transformer_.staticClass, "getOutputProperty", "(Ljava/lang/String;)Ljava/lang/String;", ref global::javax.xml.transform.Transformer_._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public override void setErrorListener(javax.xml.transform.ErrorListener arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.xml.transform.Transformer_.staticClass, "setErrorListener", "(Ljavax/xml/transform/ErrorListener;)V", ref global::javax.xml.transform.Transformer_._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public override global::javax.xml.transform.ErrorListener getErrorListener()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<javax.xml.transform.ErrorListener>(this, global::javax.xml.transform.Transformer_.staticClass, "getErrorListener", "()Ljavax/xml/transform/ErrorListener;", ref global::javax.xml.transform.Transformer_._m11) as javax.xml.transform.ErrorListener;
		}
		static Transformer_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.xml.transform.Transformer_.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/xml/transform/Transformer"));
		}
		internal static void InitJNI()
		{
		}
	}
}
