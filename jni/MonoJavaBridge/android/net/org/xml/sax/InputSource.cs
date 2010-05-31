namespace org.xml.sax 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class InputSource : java.lang.Object
	{ 
		internal static global::java.lang.Class staticClass; 
		static InputSource() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::org.xml.sax.InputSource), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::org.xml.sax.InputSource(@__env); 
			} 
		} 
		protected InputSource(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getEncoding13306; 
		public virtual global::java.lang.String getEncoding() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::org.xml.sax.InputSource._getEncoding13306)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::org.xml.sax.InputSource.staticClass, global::org.xml.sax.InputSource._getEncoding13306)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setEncoding13307; 
		public virtual void setEncoding(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::org.xml.sax.InputSource._setEncoding13307, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::org.xml.sax.InputSource.staticClass, global::org.xml.sax.InputSource._setEncoding13307, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getPublicId13308; 
		public virtual global::java.lang.String getPublicId() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::org.xml.sax.InputSource._getPublicId13308)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::org.xml.sax.InputSource.staticClass, global::org.xml.sax.InputSource._getPublicId13308)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getSystemId13309; 
		public virtual global::java.lang.String getSystemId() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::org.xml.sax.InputSource._getSystemId13309)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::org.xml.sax.InputSource.staticClass, global::org.xml.sax.InputSource._getSystemId13309)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getCharacterStream13310; 
		public virtual global::java.io.Reader getCharacterStream() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.io.Reader>(@__env, @__env.CallObjectMethodPtr(this, global::org.xml.sax.InputSource._getCharacterStream13310)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.io.Reader>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::org.xml.sax.InputSource.staticClass, global::org.xml.sax.InputSource._getCharacterStream13310)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setCharacterStream13311; 
		public virtual void setCharacterStream(java.io.Reader arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::org.xml.sax.InputSource._setCharacterStream13311, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::org.xml.sax.InputSource.staticClass, global::org.xml.sax.InputSource._setCharacterStream13311, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setSystemId13312; 
		public virtual void setSystemId(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::org.xml.sax.InputSource._setSystemId13312, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::org.xml.sax.InputSource.staticClass, global::org.xml.sax.InputSource._setSystemId13312, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setPublicId13313; 
		public virtual void setPublicId(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::org.xml.sax.InputSource._setPublicId13313, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::org.xml.sax.InputSource.staticClass, global::org.xml.sax.InputSource._setPublicId13313, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setByteStream13314; 
		public virtual void setByteStream(java.io.InputStream arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::org.xml.sax.InputSource._setByteStream13314, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::org.xml.sax.InputSource.staticClass, global::org.xml.sax.InputSource._setByteStream13314, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getByteStream13315; 
		public virtual global::java.io.InputStream getByteStream() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.io.InputStream>(@__env, @__env.CallObjectMethodPtr(this, global::org.xml.sax.InputSource._getByteStream13315)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.io.InputStream>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::org.xml.sax.InputSource.staticClass, global::org.xml.sax.InputSource._getByteStream13315)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _InputSource13316; 
		public InputSource(java.io.Reader arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(org.xml.sax.InputSource.staticClass, global::org.xml.sax.InputSource._InputSource13316, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _InputSource13317; 
		public InputSource(java.lang.String arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(org.xml.sax.InputSource.staticClass, global::org.xml.sax.InputSource._InputSource13317, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _InputSource13318; 
		public InputSource(java.io.InputStream arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(org.xml.sax.InputSource.staticClass, global::org.xml.sax.InputSource._InputSource13318, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _InputSource13319; 
		public InputSource()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(org.xml.sax.InputSource.staticClass, global::org.xml.sax.InputSource._InputSource13319, this); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::org.xml.sax.InputSource.staticClass = @__class; 
			global::org.xml.sax.InputSource._getEncoding13306 = @__env.GetMethodID(global::org.xml.sax.InputSource.staticClass, "getEncoding", "()Ljava/lang/String;"); 
			global::org.xml.sax.InputSource._setEncoding13307 = @__env.GetMethodID(global::org.xml.sax.InputSource.staticClass, "setEncoding", "(Ljava/lang/String;)V"); 
			global::org.xml.sax.InputSource._getPublicId13308 = @__env.GetMethodID(global::org.xml.sax.InputSource.staticClass, "getPublicId", "()Ljava/lang/String;"); 
			global::org.xml.sax.InputSource._getSystemId13309 = @__env.GetMethodID(global::org.xml.sax.InputSource.staticClass, "getSystemId", "()Ljava/lang/String;"); 
			global::org.xml.sax.InputSource._getCharacterStream13310 = @__env.GetMethodID(global::org.xml.sax.InputSource.staticClass, "getCharacterStream", "()Ljava/io/Reader;"); 
			global::org.xml.sax.InputSource._setCharacterStream13311 = @__env.GetMethodID(global::org.xml.sax.InputSource.staticClass, "setCharacterStream", "(Ljava/io/Reader;)V"); 
			global::org.xml.sax.InputSource._setSystemId13312 = @__env.GetMethodID(global::org.xml.sax.InputSource.staticClass, "setSystemId", "(Ljava/lang/String;)V"); 
			global::org.xml.sax.InputSource._setPublicId13313 = @__env.GetMethodID(global::org.xml.sax.InputSource.staticClass, "setPublicId", "(Ljava/lang/String;)V"); 
			global::org.xml.sax.InputSource._setByteStream13314 = @__env.GetMethodID(global::org.xml.sax.InputSource.staticClass, "setByteStream", "(Ljava/io/InputStream;)V"); 
			global::org.xml.sax.InputSource._getByteStream13315 = @__env.GetMethodID(global::org.xml.sax.InputSource.staticClass, "getByteStream", "()Ljava/io/InputStream;"); 
			global::org.xml.sax.InputSource._InputSource13316 = @__env.GetMethodID(global::org.xml.sax.InputSource.staticClass, "<init>", "(Ljava/io/Reader;)V"); 
			global::org.xml.sax.InputSource._InputSource13317 = @__env.GetMethodID(global::org.xml.sax.InputSource.staticClass, "<init>", "(Ljava/lang/String;)V"); 
			global::org.xml.sax.InputSource._InputSource13318 = @__env.GetMethodID(global::org.xml.sax.InputSource.staticClass, "<init>", "(Ljava/io/InputStream;)V"); 
			global::org.xml.sax.InputSource._InputSource13319 = @__env.GetMethodID(global::org.xml.sax.InputSource.staticClass, "<init>", "()V"); 
		} 
	} 
} 
