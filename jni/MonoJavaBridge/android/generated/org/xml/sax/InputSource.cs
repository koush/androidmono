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
		internal static global::net.sf.jni4net.jni.MethodId _getEncoding14585;
		public virtual global::java.lang.String getEncoding() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::org.xml.sax.InputSource._getEncoding14585));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::org.xml.sax.InputSource.staticClass, global::org.xml.sax.InputSource._getEncoding14585));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setEncoding14586;
		public virtual void setEncoding(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::org.xml.sax.InputSource._setEncoding14586, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::org.xml.sax.InputSource.staticClass, global::org.xml.sax.InputSource._setEncoding14586, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getPublicId14587;
		public virtual global::java.lang.String getPublicId() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::org.xml.sax.InputSource._getPublicId14587));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::org.xml.sax.InputSource.staticClass, global::org.xml.sax.InputSource._getPublicId14587));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getSystemId14588;
		public virtual global::java.lang.String getSystemId() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::org.xml.sax.InputSource._getSystemId14588));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::org.xml.sax.InputSource.staticClass, global::org.xml.sax.InputSource._getSystemId14588));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getCharacterStream14589;
		public virtual global::java.io.Reader getCharacterStream() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.io.Reader>(@__env, @__env.CallObjectMethodPtr(this, global::org.xml.sax.InputSource._getCharacterStream14589));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.io.Reader>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::org.xml.sax.InputSource.staticClass, global::org.xml.sax.InputSource._getCharacterStream14589));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setCharacterStream14590;
		public virtual void setCharacterStream(java.io.Reader arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::org.xml.sax.InputSource._setCharacterStream14590, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::org.xml.sax.InputSource.staticClass, global::org.xml.sax.InputSource._setCharacterStream14590, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setSystemId14591;
		public virtual void setSystemId(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::org.xml.sax.InputSource._setSystemId14591, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::org.xml.sax.InputSource.staticClass, global::org.xml.sax.InputSource._setSystemId14591, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setPublicId14592;
		public virtual void setPublicId(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::org.xml.sax.InputSource._setPublicId14592, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::org.xml.sax.InputSource.staticClass, global::org.xml.sax.InputSource._setPublicId14592, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setByteStream14593;
		public virtual void setByteStream(java.io.InputStream arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::org.xml.sax.InputSource._setByteStream14593, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::org.xml.sax.InputSource.staticClass, global::org.xml.sax.InputSource._setByteStream14593, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getByteStream14594;
		public virtual global::java.io.InputStream getByteStream() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.io.InputStream>(@__env, @__env.CallObjectMethodPtr(this, global::org.xml.sax.InputSource._getByteStream14594));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.io.InputStream>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::org.xml.sax.InputSource.staticClass, global::org.xml.sax.InputSource._getByteStream14594));
		}
		internal static global::net.sf.jni4net.jni.MethodId _InputSource14595;
		public InputSource(java.io.Reader arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(org.xml.sax.InputSource.staticClass, global::org.xml.sax.InputSource._InputSource14595, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _InputSource14596;
		public InputSource(java.lang.String arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(org.xml.sax.InputSource.staticClass, global::org.xml.sax.InputSource._InputSource14596, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _InputSource14597;
		public InputSource(java.io.InputStream arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(org.xml.sax.InputSource.staticClass, global::org.xml.sax.InputSource._InputSource14597, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _InputSource14598;
		public InputSource()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(org.xml.sax.InputSource.staticClass, global::org.xml.sax.InputSource._InputSource14598, this);
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::org.xml.sax.InputSource.staticClass = @__class;
			global::org.xml.sax.InputSource._getEncoding14585 = @__env.GetMethodID(global::org.xml.sax.InputSource.staticClass, "getEncoding", "()Ljava/lang/String;");
			global::org.xml.sax.InputSource._setEncoding14586 = @__env.GetMethodID(global::org.xml.sax.InputSource.staticClass, "setEncoding", "(Ljava/lang/String;)V");
			global::org.xml.sax.InputSource._getPublicId14587 = @__env.GetMethodID(global::org.xml.sax.InputSource.staticClass, "getPublicId", "()Ljava/lang/String;");
			global::org.xml.sax.InputSource._getSystemId14588 = @__env.GetMethodID(global::org.xml.sax.InputSource.staticClass, "getSystemId", "()Ljava/lang/String;");
			global::org.xml.sax.InputSource._getCharacterStream14589 = @__env.GetMethodID(global::org.xml.sax.InputSource.staticClass, "getCharacterStream", "()Ljava/io/Reader;");
			global::org.xml.sax.InputSource._setCharacterStream14590 = @__env.GetMethodID(global::org.xml.sax.InputSource.staticClass, "setCharacterStream", "(Ljava/io/Reader;)V");
			global::org.xml.sax.InputSource._setSystemId14591 = @__env.GetMethodID(global::org.xml.sax.InputSource.staticClass, "setSystemId", "(Ljava/lang/String;)V");
			global::org.xml.sax.InputSource._setPublicId14592 = @__env.GetMethodID(global::org.xml.sax.InputSource.staticClass, "setPublicId", "(Ljava/lang/String;)V");
			global::org.xml.sax.InputSource._setByteStream14593 = @__env.GetMethodID(global::org.xml.sax.InputSource.staticClass, "setByteStream", "(Ljava/io/InputStream;)V");
			global::org.xml.sax.InputSource._getByteStream14594 = @__env.GetMethodID(global::org.xml.sax.InputSource.staticClass, "getByteStream", "()Ljava/io/InputStream;");
			global::org.xml.sax.InputSource._InputSource14595 = @__env.GetMethodID(global::org.xml.sax.InputSource.staticClass, "<init>", "(Ljava/io/Reader;)V");
			global::org.xml.sax.InputSource._InputSource14596 = @__env.GetMethodID(global::org.xml.sax.InputSource.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::org.xml.sax.InputSource._InputSource14597 = @__env.GetMethodID(global::org.xml.sax.InputSource.staticClass, "<init>", "(Ljava/io/InputStream;)V");
			global::org.xml.sax.InputSource._InputSource14598 = @__env.GetMethodID(global::org.xml.sax.InputSource.staticClass, "<init>", "()V");
		}
	}
}
