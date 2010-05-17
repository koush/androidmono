namespace org.xml.sax 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class InputSource : java.lang.Object
	{ 
		internal static global::java.lang.Class staticClass; 
		static InputSource() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(org.xml.sax.InputSource), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
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
		internal static global::net.sf.jni4net.jni.MethodId _getEncoding12177; 
		public virtual java.lang.String getEncoding() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(org.xml.sax.InputSource)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _getEncoding12177)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, org.xml.sax.InputSource.staticClass, _getEncoding12177)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setEncoding12178; 
		public virtual void setEncoding(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(org.xml.sax.InputSource)) 
				@__env.CallVoidMethod(this, _setEncoding12178, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, org.xml.sax.InputSource.staticClass, _setEncoding12178, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getPublicId12179; 
		public virtual java.lang.String getPublicId() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(org.xml.sax.InputSource)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _getPublicId12179)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, org.xml.sax.InputSource.staticClass, _getPublicId12179)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getSystemId12180; 
		public virtual java.lang.String getSystemId() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(org.xml.sax.InputSource)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _getSystemId12180)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, org.xml.sax.InputSource.staticClass, _getSystemId12180)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getCharacterStream12181; 
		public virtual java.io.Reader getCharacterStream() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(org.xml.sax.InputSource)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.io.Reader>(@__env, @__env.CallObjectMethodPtr(this, _getCharacterStream12181)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.io.Reader>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, org.xml.sax.InputSource.staticClass, _getCharacterStream12181)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setCharacterStream12182; 
		public virtual void setCharacterStream(java.io.Reader arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(org.xml.sax.InputSource)) 
				@__env.CallVoidMethod(this, _setCharacterStream12182, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, org.xml.sax.InputSource.staticClass, _setCharacterStream12182, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setSystemId12183; 
		public virtual void setSystemId(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(org.xml.sax.InputSource)) 
				@__env.CallVoidMethod(this, _setSystemId12183, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, org.xml.sax.InputSource.staticClass, _setSystemId12183, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setPublicId12184; 
		public virtual void setPublicId(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(org.xml.sax.InputSource)) 
				@__env.CallVoidMethod(this, _setPublicId12184, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, org.xml.sax.InputSource.staticClass, _setPublicId12184, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setByteStream12185; 
		public virtual void setByteStream(java.io.InputStream arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(org.xml.sax.InputSource)) 
				@__env.CallVoidMethod(this, _setByteStream12185, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, org.xml.sax.InputSource.staticClass, _setByteStream12185, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getByteStream12186; 
		public virtual java.io.InputStream getByteStream() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(org.xml.sax.InputSource)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.io.InputStream>(@__env, @__env.CallObjectMethodPtr(this, _getByteStream12186)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.io.InputStream>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, org.xml.sax.InputSource.staticClass, _getByteStream12186)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _InputSource12187; 
		public InputSource(java.io.Reader arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(org.xml.sax.InputSource.staticClass, _InputSource12187, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _InputSource12188; 
		public InputSource(java.lang.String arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(org.xml.sax.InputSource.staticClass, _InputSource12188, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _InputSource12189; 
		public InputSource(java.io.InputStream arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(org.xml.sax.InputSource.staticClass, _InputSource12189, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _InputSource12190; 
		public InputSource()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(org.xml.sax.InputSource.staticClass, _InputSource12190, this); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::org.xml.sax.InputSource.staticClass = @__class; 
			global::org.xml.sax.InputSource._getEncoding12177 = @__env.GetMethodID(global::org.xml.sax.InputSource.staticClass, "getEncoding", "()Ljava/lang/String;"); 
			global::org.xml.sax.InputSource._setEncoding12178 = @__env.GetMethodID(global::org.xml.sax.InputSource.staticClass, "setEncoding", "(Ljava/lang/String;)V"); 
			global::org.xml.sax.InputSource._getPublicId12179 = @__env.GetMethodID(global::org.xml.sax.InputSource.staticClass, "getPublicId", "()Ljava/lang/String;"); 
			global::org.xml.sax.InputSource._getSystemId12180 = @__env.GetMethodID(global::org.xml.sax.InputSource.staticClass, "getSystemId", "()Ljava/lang/String;"); 
			global::org.xml.sax.InputSource._getCharacterStream12181 = @__env.GetMethodID(global::org.xml.sax.InputSource.staticClass, "getCharacterStream", "()Ljava/io/Reader;"); 
			global::org.xml.sax.InputSource._setCharacterStream12182 = @__env.GetMethodID(global::org.xml.sax.InputSource.staticClass, "setCharacterStream", "(Ljava/io/Reader;)V"); 
			global::org.xml.sax.InputSource._setSystemId12183 = @__env.GetMethodID(global::org.xml.sax.InputSource.staticClass, "setSystemId", "(Ljava/lang/String;)V"); 
			global::org.xml.sax.InputSource._setPublicId12184 = @__env.GetMethodID(global::org.xml.sax.InputSource.staticClass, "setPublicId", "(Ljava/lang/String;)V"); 
			global::org.xml.sax.InputSource._setByteStream12185 = @__env.GetMethodID(global::org.xml.sax.InputSource.staticClass, "setByteStream", "(Ljava/io/InputStream;)V"); 
			global::org.xml.sax.InputSource._getByteStream12186 = @__env.GetMethodID(global::org.xml.sax.InputSource.staticClass, "getByteStream", "()Ljava/io/InputStream;"); 
			global::org.xml.sax.InputSource._InputSource12187 = @__env.GetMethodID(global::org.xml.sax.InputSource.staticClass, "<init>", "(Ljava/io/Reader;)V"); 
			global::org.xml.sax.InputSource._InputSource12188 = @__env.GetMethodID(global::org.xml.sax.InputSource.staticClass, "<init>", "(Ljava/lang/String;)V"); 
			global::org.xml.sax.InputSource._InputSource12189 = @__env.GetMethodID(global::org.xml.sax.InputSource.staticClass, "<init>", "(Ljava/io/InputStream;)V"); 
			global::org.xml.sax.InputSource._InputSource12190 = @__env.GetMethodID(global::org.xml.sax.InputSource.staticClass, "<init>", "()V"); 
		} 
	} 
} 
