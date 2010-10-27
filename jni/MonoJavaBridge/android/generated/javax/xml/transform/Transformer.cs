namespace javax.xml.transform
{
	[global::MonoJavaBridge.JavaClass(typeof(global::javax.xml.transform.Transformer_))]
	public abstract partial class Transformer : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Transformer()
		{
			InitJNI();
		}
		protected Transformer(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _transform30958;
		public abstract void transform(javax.xml.transform.Source arg0, javax.xml.transform.Result arg1);
		internal static global::MonoJavaBridge.MethodId _reset30959;
		public virtual void reset()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.transform.Transformer._reset30959);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.xml.transform.Transformer.staticClass, global::javax.xml.transform.Transformer._reset30959);
		}
		internal static global::MonoJavaBridge.MethodId _setParameter30960;
		public abstract void setParameter(java.lang.String arg0, java.lang.Object arg1);
		internal static global::MonoJavaBridge.MethodId _getParameter30961;
		public abstract global::java.lang.Object getParameter(java.lang.String arg0);
		internal static global::MonoJavaBridge.MethodId _clearParameters30962;
		public abstract void clearParameters();
		internal static global::MonoJavaBridge.MethodId _getOutputProperties30963;
		public abstract global::java.util.Properties getOutputProperties();
		internal static global::MonoJavaBridge.MethodId _setURIResolver30964;
		public abstract void setURIResolver(javax.xml.transform.URIResolver arg0);
		internal static global::MonoJavaBridge.MethodId _getURIResolver30965;
		public abstract global::javax.xml.transform.URIResolver getURIResolver();
		internal static global::MonoJavaBridge.MethodId _setOutputProperties30966;
		public abstract void setOutputProperties(java.util.Properties arg0);
		internal static global::MonoJavaBridge.MethodId _setOutputProperty30967;
		public abstract void setOutputProperty(java.lang.String arg0, java.lang.String arg1);
		internal static global::MonoJavaBridge.MethodId _getOutputProperty30968;
		public abstract global::java.lang.String getOutputProperty(java.lang.String arg0);
		internal static global::MonoJavaBridge.MethodId _setErrorListener30969;
		public abstract void setErrorListener(javax.xml.transform.ErrorListener arg0);
		internal static global::MonoJavaBridge.MethodId _getErrorListener30970;
		public abstract global::javax.xml.transform.ErrorListener getErrorListener();
		internal static global::MonoJavaBridge.MethodId _Transformer30971;
		protected Transformer() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.xml.transform.Transformer.staticClass, global::javax.xml.transform.Transformer._Transformer30971);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.xml.transform.Transformer.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/xml/transform/Transformer"));
			global::javax.xml.transform.Transformer._transform30958 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.Transformer.staticClass, "transform", "(Ljavax/xml/transform/Source;Ljavax/xml/transform/Result;)V");
			global::javax.xml.transform.Transformer._reset30959 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.Transformer.staticClass, "reset", "()V");
			global::javax.xml.transform.Transformer._setParameter30960 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.Transformer.staticClass, "setParameter", "(Ljava/lang/String;Ljava/lang/Object;)V");
			global::javax.xml.transform.Transformer._getParameter30961 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.Transformer.staticClass, "getParameter", "(Ljava/lang/String;)Ljava/lang/Object;");
			global::javax.xml.transform.Transformer._clearParameters30962 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.Transformer.staticClass, "clearParameters", "()V");
			global::javax.xml.transform.Transformer._getOutputProperties30963 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.Transformer.staticClass, "getOutputProperties", "()Ljava/util/Properties;");
			global::javax.xml.transform.Transformer._setURIResolver30964 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.Transformer.staticClass, "setURIResolver", "(Ljavax/xml/transform/URIResolver;)V");
			global::javax.xml.transform.Transformer._getURIResolver30965 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.Transformer.staticClass, "getURIResolver", "()Ljavax/xml/transform/URIResolver;");
			global::javax.xml.transform.Transformer._setOutputProperties30966 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.Transformer.staticClass, "setOutputProperties", "(Ljava/util/Properties;)V");
			global::javax.xml.transform.Transformer._setOutputProperty30967 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.Transformer.staticClass, "setOutputProperty", "(Ljava/lang/String;Ljava/lang/String;)V");
			global::javax.xml.transform.Transformer._getOutputProperty30968 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.Transformer.staticClass, "getOutputProperty", "(Ljava/lang/String;)Ljava/lang/String;");
			global::javax.xml.transform.Transformer._setErrorListener30969 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.Transformer.staticClass, "setErrorListener", "(Ljavax/xml/transform/ErrorListener;)V");
			global::javax.xml.transform.Transformer._getErrorListener30970 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.Transformer.staticClass, "getErrorListener", "()Ljavax/xml/transform/ErrorListener;");
			global::javax.xml.transform.Transformer._Transformer30971 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.Transformer.staticClass, "<init>", "()V");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::javax.xml.transform.Transformer))]
	internal sealed partial class Transformer_ : javax.xml.transform.Transformer
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Transformer_()
		{
			InitJNI();
		}
		internal Transformer_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _transform30972;
		public override void transform(javax.xml.transform.Source arg0, javax.xml.transform.Result arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.transform.Transformer_._transform30972, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.xml.transform.Transformer_.staticClass, global::javax.xml.transform.Transformer_._transform30972, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setParameter30973;
		public override void setParameter(java.lang.String arg0, java.lang.Object arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.transform.Transformer_._setParameter30973, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.xml.transform.Transformer_.staticClass, global::javax.xml.transform.Transformer_._setParameter30973, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getParameter30974;
		public override global::java.lang.Object getParameter(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.transform.Transformer_._getParameter30974, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.xml.transform.Transformer_.staticClass, global::javax.xml.transform.Transformer_._getParameter30974, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _clearParameters30975;
		public override void clearParameters()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.transform.Transformer_._clearParameters30975);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.xml.transform.Transformer_.staticClass, global::javax.xml.transform.Transformer_._clearParameters30975);
		}
		internal static global::MonoJavaBridge.MethodId _getOutputProperties30976;
		public override global::java.util.Properties getOutputProperties()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.transform.Transformer_._getOutputProperties30976)) as java.util.Properties;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.xml.transform.Transformer_.staticClass, global::javax.xml.transform.Transformer_._getOutputProperties30976)) as java.util.Properties;
		}
		internal static global::MonoJavaBridge.MethodId _setURIResolver30977;
		public override void setURIResolver(javax.xml.transform.URIResolver arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.transform.Transformer_._setURIResolver30977, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.xml.transform.Transformer_.staticClass, global::javax.xml.transform.Transformer_._setURIResolver30977, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getURIResolver30978;
		public override global::javax.xml.transform.URIResolver getURIResolver()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::javax.xml.transform.URIResolver>(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.transform.Transformer_._getURIResolver30978)) as javax.xml.transform.URIResolver;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::javax.xml.transform.URIResolver>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.xml.transform.Transformer_.staticClass, global::javax.xml.transform.Transformer_._getURIResolver30978)) as javax.xml.transform.URIResolver;
		}
		internal static global::MonoJavaBridge.MethodId _setOutputProperties30979;
		public override void setOutputProperties(java.util.Properties arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.transform.Transformer_._setOutputProperties30979, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.xml.transform.Transformer_.staticClass, global::javax.xml.transform.Transformer_._setOutputProperties30979, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setOutputProperty30980;
		public override void setOutputProperty(java.lang.String arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.transform.Transformer_._setOutputProperty30980, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.xml.transform.Transformer_.staticClass, global::javax.xml.transform.Transformer_._setOutputProperty30980, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getOutputProperty30981;
		public override global::java.lang.String getOutputProperty(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.transform.Transformer_._getOutputProperty30981, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.xml.transform.Transformer_.staticClass, global::javax.xml.transform.Transformer_._getOutputProperty30981, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _setErrorListener30982;
		public override void setErrorListener(javax.xml.transform.ErrorListener arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.transform.Transformer_._setErrorListener30982, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.xml.transform.Transformer_.staticClass, global::javax.xml.transform.Transformer_._setErrorListener30982, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getErrorListener30983;
		public override global::javax.xml.transform.ErrorListener getErrorListener()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::javax.xml.transform.ErrorListener>(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.transform.Transformer_._getErrorListener30983)) as javax.xml.transform.ErrorListener;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::javax.xml.transform.ErrorListener>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.xml.transform.Transformer_.staticClass, global::javax.xml.transform.Transformer_._getErrorListener30983)) as javax.xml.transform.ErrorListener;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.xml.transform.Transformer_.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/xml/transform/Transformer"));
			global::javax.xml.transform.Transformer_._transform30972 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.Transformer_.staticClass, "transform", "(Ljavax/xml/transform/Source;Ljavax/xml/transform/Result;)V");
			global::javax.xml.transform.Transformer_._setParameter30973 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.Transformer_.staticClass, "setParameter", "(Ljava/lang/String;Ljava/lang/Object;)V");
			global::javax.xml.transform.Transformer_._getParameter30974 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.Transformer_.staticClass, "getParameter", "(Ljava/lang/String;)Ljava/lang/Object;");
			global::javax.xml.transform.Transformer_._clearParameters30975 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.Transformer_.staticClass, "clearParameters", "()V");
			global::javax.xml.transform.Transformer_._getOutputProperties30976 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.Transformer_.staticClass, "getOutputProperties", "()Ljava/util/Properties;");
			global::javax.xml.transform.Transformer_._setURIResolver30977 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.Transformer_.staticClass, "setURIResolver", "(Ljavax/xml/transform/URIResolver;)V");
			global::javax.xml.transform.Transformer_._getURIResolver30978 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.Transformer_.staticClass, "getURIResolver", "()Ljavax/xml/transform/URIResolver;");
			global::javax.xml.transform.Transformer_._setOutputProperties30979 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.Transformer_.staticClass, "setOutputProperties", "(Ljava/util/Properties;)V");
			global::javax.xml.transform.Transformer_._setOutputProperty30980 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.Transformer_.staticClass, "setOutputProperty", "(Ljava/lang/String;Ljava/lang/String;)V");
			global::javax.xml.transform.Transformer_._getOutputProperty30981 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.Transformer_.staticClass, "getOutputProperty", "(Ljava/lang/String;)Ljava/lang/String;");
			global::javax.xml.transform.Transformer_._setErrorListener30982 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.Transformer_.staticClass, "setErrorListener", "(Ljavax/xml/transform/ErrorListener;)V");
			global::javax.xml.transform.Transformer_._getErrorListener30983 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.Transformer_.staticClass, "getErrorListener", "()Ljavax/xml/transform/ErrorListener;");
		}
	}
}
