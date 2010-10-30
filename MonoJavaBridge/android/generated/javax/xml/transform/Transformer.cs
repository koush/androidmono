namespace javax.xml.transform
{
	[global::MonoJavaBridge.JavaClass(typeof(global::javax.xml.transform.Transformer_))]
	public abstract partial class Transformer : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected Transformer(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _transform30959;
		public abstract void transform(javax.xml.transform.Source arg0, javax.xml.transform.Result arg1);
		internal static global::MonoJavaBridge.MethodId _reset30960;
		public virtual void reset()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.xml.transform.Transformer._reset30960.native == global::System.IntPtr.Zero)
				global::javax.xml.transform.Transformer._reset30960 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.Transformer.staticClass, "reset", "()V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.xml.transform.Transformer.staticClass, global::javax.xml.transform.Transformer._reset30960);
		}
		internal static global::MonoJavaBridge.MethodId _setParameter30961;
		public abstract void setParameter(java.lang.String arg0, java.lang.Object arg1);
		internal static global::MonoJavaBridge.MethodId _getParameter30962;
		public abstract global::java.lang.Object getParameter(java.lang.String arg0);
		internal static global::MonoJavaBridge.MethodId _clearParameters30963;
		public abstract void clearParameters();
		internal static global::MonoJavaBridge.MethodId _getOutputProperties30964;
		public abstract global::java.util.Properties getOutputProperties();
		internal static global::MonoJavaBridge.MethodId _setURIResolver30965;
		public abstract void setURIResolver(javax.xml.transform.URIResolver arg0);
		internal static global::MonoJavaBridge.MethodId _getURIResolver30966;
		public abstract global::javax.xml.transform.URIResolver getURIResolver();
		internal static global::MonoJavaBridge.MethodId _setOutputProperties30967;
		public abstract void setOutputProperties(java.util.Properties arg0);
		internal static global::MonoJavaBridge.MethodId _setOutputProperty30968;
		public abstract void setOutputProperty(java.lang.String arg0, java.lang.String arg1);
		internal static global::MonoJavaBridge.MethodId _getOutputProperty30969;
		public abstract global::java.lang.String getOutputProperty(java.lang.String arg0);
		internal static global::MonoJavaBridge.MethodId _setErrorListener30970;
		public abstract void setErrorListener(javax.xml.transform.ErrorListener arg0);
		internal static global::MonoJavaBridge.MethodId _getErrorListener30971;
		public abstract global::javax.xml.transform.ErrorListener getErrorListener();
		internal static global::MonoJavaBridge.MethodId _Transformer30972;
		protected Transformer() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.xml.transform.Transformer._Transformer30972.native == global::System.IntPtr.Zero)
				global::javax.xml.transform.Transformer._Transformer30972 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.Transformer.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.xml.transform.Transformer.staticClass, global::javax.xml.transform.Transformer._Transformer30972);
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
		internal static global::MonoJavaBridge.MethodId _transform30973;
		public override void transform(javax.xml.transform.Source arg0, javax.xml.transform.Result arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.xml.transform.Transformer_._transform30973.native == global::System.IntPtr.Zero)
				global::javax.xml.transform.Transformer_._transform30973 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.Transformer_.staticClass, "transform", "(Ljavax/xml/transform/Source;Ljavax/xml/transform/Result;)V");
			@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.transform.Transformer_._transform30973, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setParameter30974;
		public override void setParameter(java.lang.String arg0, java.lang.Object arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.xml.transform.Transformer_._setParameter30974.native == global::System.IntPtr.Zero)
				global::javax.xml.transform.Transformer_._setParameter30974 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.Transformer_.staticClass, "setParameter", "(Ljava/lang/String;Ljava/lang/Object;)V");
			@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.transform.Transformer_._setParameter30974, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getParameter30975;
		public override global::java.lang.Object getParameter(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.xml.transform.Transformer_._getParameter30975.native == global::System.IntPtr.Zero)
				global::javax.xml.transform.Transformer_._getParameter30975 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.Transformer_.staticClass, "getParameter", "(Ljava/lang/String;)Ljava/lang/Object;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.transform.Transformer_._getParameter30975, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _clearParameters30976;
		public override void clearParameters()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.xml.transform.Transformer_._clearParameters30976.native == global::System.IntPtr.Zero)
				global::javax.xml.transform.Transformer_._clearParameters30976 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.Transformer_.staticClass, "clearParameters", "()V");
			@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.transform.Transformer_._clearParameters30976);
		}
		internal static global::MonoJavaBridge.MethodId _getOutputProperties30977;
		public override global::java.util.Properties getOutputProperties()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.xml.transform.Transformer_._getOutputProperties30977.native == global::System.IntPtr.Zero)
				global::javax.xml.transform.Transformer_._getOutputProperties30977 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.Transformer_.staticClass, "getOutputProperties", "()Ljava/util/Properties;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.transform.Transformer_._getOutputProperties30977)) as java.util.Properties;
		}
		internal static global::MonoJavaBridge.MethodId _setURIResolver30978;
		public override void setURIResolver(javax.xml.transform.URIResolver arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.xml.transform.Transformer_._setURIResolver30978.native == global::System.IntPtr.Zero)
				global::javax.xml.transform.Transformer_._setURIResolver30978 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.Transformer_.staticClass, "setURIResolver", "(Ljavax/xml/transform/URIResolver;)V");
			@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.transform.Transformer_._setURIResolver30978, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getURIResolver30979;
		public override global::javax.xml.transform.URIResolver getURIResolver()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.xml.transform.Transformer_._getURIResolver30979.native == global::System.IntPtr.Zero)
				global::javax.xml.transform.Transformer_._getURIResolver30979 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.Transformer_.staticClass, "getURIResolver", "()Ljavax/xml/transform/URIResolver;");
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::javax.xml.transform.URIResolver>(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.transform.Transformer_._getURIResolver30979)) as javax.xml.transform.URIResolver;
		}
		internal static global::MonoJavaBridge.MethodId _setOutputProperties30980;
		public override void setOutputProperties(java.util.Properties arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.xml.transform.Transformer_._setOutputProperties30980.native == global::System.IntPtr.Zero)
				global::javax.xml.transform.Transformer_._setOutputProperties30980 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.Transformer_.staticClass, "setOutputProperties", "(Ljava/util/Properties;)V");
			@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.transform.Transformer_._setOutputProperties30980, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setOutputProperty30981;
		public override void setOutputProperty(java.lang.String arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.xml.transform.Transformer_._setOutputProperty30981.native == global::System.IntPtr.Zero)
				global::javax.xml.transform.Transformer_._setOutputProperty30981 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.Transformer_.staticClass, "setOutputProperty", "(Ljava/lang/String;Ljava/lang/String;)V");
			@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.transform.Transformer_._setOutputProperty30981, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getOutputProperty30982;
		public override global::java.lang.String getOutputProperty(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.xml.transform.Transformer_._getOutputProperty30982.native == global::System.IntPtr.Zero)
				global::javax.xml.transform.Transformer_._getOutputProperty30982 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.Transformer_.staticClass, "getOutputProperty", "(Ljava/lang/String;)Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.transform.Transformer_._getOutputProperty30982, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _setErrorListener30983;
		public override void setErrorListener(javax.xml.transform.ErrorListener arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.xml.transform.Transformer_._setErrorListener30983.native == global::System.IntPtr.Zero)
				global::javax.xml.transform.Transformer_._setErrorListener30983 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.Transformer_.staticClass, "setErrorListener", "(Ljavax/xml/transform/ErrorListener;)V");
			@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.transform.Transformer_._setErrorListener30983, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getErrorListener30984;
		public override global::javax.xml.transform.ErrorListener getErrorListener()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.xml.transform.Transformer_._getErrorListener30984.native == global::System.IntPtr.Zero)
				global::javax.xml.transform.Transformer_._getErrorListener30984 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.Transformer_.staticClass, "getErrorListener", "()Ljavax/xml/transform/ErrorListener;");
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::javax.xml.transform.ErrorListener>(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.transform.Transformer_._getErrorListener30984)) as javax.xml.transform.ErrorListener;
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
