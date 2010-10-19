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
		internal static global::MonoJavaBridge.MethodId _transform24363;
		public abstract void transform(javax.xml.transform.Source arg0, javax.xml.transform.Result arg1);
		internal static global::MonoJavaBridge.MethodId _reset24364;
		public virtual void reset() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.transform.Transformer._reset24364);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.xml.transform.Transformer.staticClass, global::javax.xml.transform.Transformer._reset24364);
		}
		internal static global::MonoJavaBridge.MethodId _setParameter24365;
		public abstract void setParameter(java.lang.String arg0, java.lang.Object arg1);
		internal static global::MonoJavaBridge.MethodId _getParameter24366;
		public abstract global::java.lang.Object getParameter(java.lang.String arg0);
		internal static global::MonoJavaBridge.MethodId _clearParameters24367;
		public abstract void clearParameters();
		internal static global::MonoJavaBridge.MethodId _getOutputProperties24368;
		public abstract global::java.util.Properties getOutputProperties();
		internal static global::MonoJavaBridge.MethodId _setURIResolver24369;
		public abstract void setURIResolver(javax.xml.transform.URIResolver arg0);
		internal static global::MonoJavaBridge.MethodId _getURIResolver24370;
		public abstract global::javax.xml.transform.URIResolver getURIResolver();
		internal static global::MonoJavaBridge.MethodId _setOutputProperties24371;
		public abstract void setOutputProperties(java.util.Properties arg0);
		internal static global::MonoJavaBridge.MethodId _setOutputProperty24372;
		public abstract void setOutputProperty(java.lang.String arg0, java.lang.String arg1);
		internal static global::MonoJavaBridge.MethodId _getOutputProperty24373;
		public abstract global::java.lang.String getOutputProperty(java.lang.String arg0);
		internal static global::MonoJavaBridge.MethodId _setErrorListener24374;
		public abstract void setErrorListener(javax.xml.transform.ErrorListener arg0);
		internal static global::MonoJavaBridge.MethodId _getErrorListener24375;
		public abstract global::javax.xml.transform.ErrorListener getErrorListener();
		internal static global::MonoJavaBridge.MethodId _Transformer24376;
		protected Transformer()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.xml.transform.Transformer.staticClass, global::javax.xml.transform.Transformer._Transformer24376);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.xml.transform.Transformer.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/xml/transform/Transformer"));
			global::javax.xml.transform.Transformer._transform24363 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.Transformer.staticClass, "transform", "(Ljavax/xml/transform/Source;Ljavax/xml/transform/Result;)V");
			global::javax.xml.transform.Transformer._reset24364 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.Transformer.staticClass, "reset", "()V");
			global::javax.xml.transform.Transformer._setParameter24365 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.Transformer.staticClass, "setParameter", "(Ljava/lang/String;Ljava/lang/Object;)V");
			global::javax.xml.transform.Transformer._getParameter24366 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.Transformer.staticClass, "getParameter", "(Ljava/lang/String;)Ljava/lang/Object;");
			global::javax.xml.transform.Transformer._clearParameters24367 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.Transformer.staticClass, "clearParameters", "()V");
			global::javax.xml.transform.Transformer._getOutputProperties24368 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.Transformer.staticClass, "getOutputProperties", "()Ljava/util/Properties;");
			global::javax.xml.transform.Transformer._setURIResolver24369 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.Transformer.staticClass, "setURIResolver", "(Ljavax/xml/transform/URIResolver;)V");
			global::javax.xml.transform.Transformer._getURIResolver24370 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.Transformer.staticClass, "getURIResolver", "()Ljavax/xml/transform/URIResolver;");
			global::javax.xml.transform.Transformer._setOutputProperties24371 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.Transformer.staticClass, "setOutputProperties", "(Ljava/util/Properties;)V");
			global::javax.xml.transform.Transformer._setOutputProperty24372 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.Transformer.staticClass, "setOutputProperty", "(Ljava/lang/String;Ljava/lang/String;)V");
			global::javax.xml.transform.Transformer._getOutputProperty24373 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.Transformer.staticClass, "getOutputProperty", "(Ljava/lang/String;)Ljava/lang/String;");
			global::javax.xml.transform.Transformer._setErrorListener24374 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.Transformer.staticClass, "setErrorListener", "(Ljavax/xml/transform/ErrorListener;)V");
			global::javax.xml.transform.Transformer._getErrorListener24375 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.Transformer.staticClass, "getErrorListener", "()Ljavax/xml/transform/ErrorListener;");
			global::javax.xml.transform.Transformer._Transformer24376 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.Transformer.staticClass, "<init>", "()V");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::javax.xml.transform.Transformer))]
	public sealed partial class Transformer_ : javax.xml.transform.Transformer
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Transformer_()
		{
			InitJNI();
		}
		internal Transformer_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _transform24377;
		public override void transform(javax.xml.transform.Source arg0, javax.xml.transform.Result arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.transform.Transformer_._transform24377, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.xml.transform.Transformer_.staticClass, global::javax.xml.transform.Transformer_._transform24377, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setParameter24378;
		public override void setParameter(java.lang.String arg0, java.lang.Object arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.transform.Transformer_._setParameter24378, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.xml.transform.Transformer_.staticClass, global::javax.xml.transform.Transformer_._setParameter24378, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getParameter24379;
		public override global::java.lang.Object getParameter(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.transform.Transformer_._getParameter24379, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.xml.transform.Transformer_.staticClass, global::javax.xml.transform.Transformer_._getParameter24379, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _clearParameters24380;
		public override void clearParameters() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.transform.Transformer_._clearParameters24380);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.xml.transform.Transformer_.staticClass, global::javax.xml.transform.Transformer_._clearParameters24380);
		}
		internal static global::MonoJavaBridge.MethodId _getOutputProperties24381;
		public override global::java.util.Properties getOutputProperties() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.transform.Transformer_._getOutputProperties24381)) as java.util.Properties;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.xml.transform.Transformer_.staticClass, global::javax.xml.transform.Transformer_._getOutputProperties24381)) as java.util.Properties;
		}
		internal static global::MonoJavaBridge.MethodId _setURIResolver24382;
		public override void setURIResolver(javax.xml.transform.URIResolver arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.transform.Transformer_._setURIResolver24382, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.xml.transform.Transformer_.staticClass, global::javax.xml.transform.Transformer_._setURIResolver24382, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getURIResolver24383;
		public override global::javax.xml.transform.URIResolver getURIResolver() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::javax.xml.transform.URIResolver>(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.transform.Transformer_._getURIResolver24383)) as javax.xml.transform.URIResolver;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::javax.xml.transform.URIResolver>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.xml.transform.Transformer_.staticClass, global::javax.xml.transform.Transformer_._getURIResolver24383)) as javax.xml.transform.URIResolver;
		}
		internal static global::MonoJavaBridge.MethodId _setOutputProperties24384;
		public override void setOutputProperties(java.util.Properties arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.transform.Transformer_._setOutputProperties24384, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.xml.transform.Transformer_.staticClass, global::javax.xml.transform.Transformer_._setOutputProperties24384, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setOutputProperty24385;
		public override void setOutputProperty(java.lang.String arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.transform.Transformer_._setOutputProperty24385, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.xml.transform.Transformer_.staticClass, global::javax.xml.transform.Transformer_._setOutputProperty24385, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getOutputProperty24386;
		public override global::java.lang.String getOutputProperty(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.transform.Transformer_._getOutputProperty24386, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.xml.transform.Transformer_.staticClass, global::javax.xml.transform.Transformer_._getOutputProperty24386, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _setErrorListener24387;
		public override void setErrorListener(javax.xml.transform.ErrorListener arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.transform.Transformer_._setErrorListener24387, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.xml.transform.Transformer_.staticClass, global::javax.xml.transform.Transformer_._setErrorListener24387, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getErrorListener24388;
		public override global::javax.xml.transform.ErrorListener getErrorListener() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::javax.xml.transform.ErrorListener>(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.transform.Transformer_._getErrorListener24388)) as javax.xml.transform.ErrorListener;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::javax.xml.transform.ErrorListener>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.xml.transform.Transformer_.staticClass, global::javax.xml.transform.Transformer_._getErrorListener24388)) as javax.xml.transform.ErrorListener;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.xml.transform.Transformer_.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/xml/transform/Transformer"));
			global::javax.xml.transform.Transformer_._transform24377 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.Transformer_.staticClass, "transform", "(Ljavax/xml/transform/Source;Ljavax/xml/transform/Result;)V");
			global::javax.xml.transform.Transformer_._setParameter24378 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.Transformer_.staticClass, "setParameter", "(Ljava/lang/String;Ljava/lang/Object;)V");
			global::javax.xml.transform.Transformer_._getParameter24379 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.Transformer_.staticClass, "getParameter", "(Ljava/lang/String;)Ljava/lang/Object;");
			global::javax.xml.transform.Transformer_._clearParameters24380 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.Transformer_.staticClass, "clearParameters", "()V");
			global::javax.xml.transform.Transformer_._getOutputProperties24381 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.Transformer_.staticClass, "getOutputProperties", "()Ljava/util/Properties;");
			global::javax.xml.transform.Transformer_._setURIResolver24382 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.Transformer_.staticClass, "setURIResolver", "(Ljavax/xml/transform/URIResolver;)V");
			global::javax.xml.transform.Transformer_._getURIResolver24383 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.Transformer_.staticClass, "getURIResolver", "()Ljavax/xml/transform/URIResolver;");
			global::javax.xml.transform.Transformer_._setOutputProperties24384 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.Transformer_.staticClass, "setOutputProperties", "(Ljava/util/Properties;)V");
			global::javax.xml.transform.Transformer_._setOutputProperty24385 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.Transformer_.staticClass, "setOutputProperty", "(Ljava/lang/String;Ljava/lang/String;)V");
			global::javax.xml.transform.Transformer_._getOutputProperty24386 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.Transformer_.staticClass, "getOutputProperty", "(Ljava/lang/String;)Ljava/lang/String;");
			global::javax.xml.transform.Transformer_._setErrorListener24387 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.Transformer_.staticClass, "setErrorListener", "(Ljavax/xml/transform/ErrorListener;)V");
			global::javax.xml.transform.Transformer_._getErrorListener24388 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.Transformer_.staticClass, "getErrorListener", "()Ljavax/xml/transform/ErrorListener;");
		}
	}
}
