namespace java.util.jar
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class Manifest : java.lang.Object, java.lang.Cloneable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Manifest()
		{
			InitJNI();
		}
		protected Manifest(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _equals27885;
		public override bool equals(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.jar.Manifest._equals27885, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.jar.Manifest.staticClass, global::java.util.jar.Manifest._equals27885, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _hashCode27886;
		public override int hashCode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.jar.Manifest._hashCode27886);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.jar.Manifest.staticClass, global::java.util.jar.Manifest._hashCode27886);
		}
		internal static global::MonoJavaBridge.MethodId _clone27887;
		public virtual global::java.lang.Object clone() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.jar.Manifest._clone27887)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.jar.Manifest.staticClass, global::java.util.jar.Manifest._clone27887)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _clear27888;
		public virtual void clear() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.jar.Manifest._clear27888);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.jar.Manifest.staticClass, global::java.util.jar.Manifest._clear27888);
		}
		internal static global::MonoJavaBridge.MethodId _write27889;
		public virtual void write(java.io.OutputStream arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.jar.Manifest._write27889, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.jar.Manifest.staticClass, global::java.util.jar.Manifest._write27889, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _read27890;
		public virtual void read(java.io.InputStream arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.jar.Manifest._read27890, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.jar.Manifest.staticClass, global::java.util.jar.Manifest._read27890, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getAttributes27891;
		public virtual global::java.util.jar.Attributes getAttributes(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.jar.Manifest._getAttributes27891, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.jar.Attributes;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.jar.Manifest.staticClass, global::java.util.jar.Manifest._getAttributes27891, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.jar.Attributes;
		}
		public new global::java.util.jar.Attributes MainAttributes
		{
			get
			{
				return getMainAttributes();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getMainAttributes27892;
		public virtual global::java.util.jar.Attributes getMainAttributes() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.jar.Manifest._getMainAttributes27892)) as java.util.jar.Attributes;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.jar.Manifest.staticClass, global::java.util.jar.Manifest._getMainAttributes27892)) as java.util.jar.Attributes;
		}
		public new global::java.util.Map Entries
		{
			get
			{
				return getEntries();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getEntries27893;
		public virtual global::java.util.Map getEntries() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Map>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.jar.Manifest._getEntries27893)) as java.util.Map;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Map>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.jar.Manifest.staticClass, global::java.util.jar.Manifest._getEntries27893)) as java.util.Map;
		}
		internal static global::MonoJavaBridge.MethodId _Manifest27894;
		public Manifest(java.io.InputStream arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.jar.Manifest.staticClass, global::java.util.jar.Manifest._Manifest27894, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Manifest27895;
		public Manifest(java.util.jar.Manifest arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.jar.Manifest.staticClass, global::java.util.jar.Manifest._Manifest27895, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Manifest27896;
		public Manifest()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.jar.Manifest.staticClass, global::java.util.jar.Manifest._Manifest27896);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.jar.Manifest.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/jar/Manifest"));
			global::java.util.jar.Manifest._equals27885 = @__env.GetMethodIDNoThrow(global::java.util.jar.Manifest.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.util.jar.Manifest._hashCode27886 = @__env.GetMethodIDNoThrow(global::java.util.jar.Manifest.staticClass, "hashCode", "()I");
			global::java.util.jar.Manifest._clone27887 = @__env.GetMethodIDNoThrow(global::java.util.jar.Manifest.staticClass, "clone", "()Ljava/lang/Object;");
			global::java.util.jar.Manifest._clear27888 = @__env.GetMethodIDNoThrow(global::java.util.jar.Manifest.staticClass, "clear", "()V");
			global::java.util.jar.Manifest._write27889 = @__env.GetMethodIDNoThrow(global::java.util.jar.Manifest.staticClass, "write", "(Ljava/io/OutputStream;)V");
			global::java.util.jar.Manifest._read27890 = @__env.GetMethodIDNoThrow(global::java.util.jar.Manifest.staticClass, "read", "(Ljava/io/InputStream;)V");
			global::java.util.jar.Manifest._getAttributes27891 = @__env.GetMethodIDNoThrow(global::java.util.jar.Manifest.staticClass, "getAttributes", "(Ljava/lang/String;)Ljava/util/jar/Attributes;");
			global::java.util.jar.Manifest._getMainAttributes27892 = @__env.GetMethodIDNoThrow(global::java.util.jar.Manifest.staticClass, "getMainAttributes", "()Ljava/util/jar/Attributes;");
			global::java.util.jar.Manifest._getEntries27893 = @__env.GetMethodIDNoThrow(global::java.util.jar.Manifest.staticClass, "getEntries", "()Ljava/util/Map;");
			global::java.util.jar.Manifest._Manifest27894 = @__env.GetMethodIDNoThrow(global::java.util.jar.Manifest.staticClass, "<init>", "(Ljava/io/InputStream;)V");
			global::java.util.jar.Manifest._Manifest27895 = @__env.GetMethodIDNoThrow(global::java.util.jar.Manifest.staticClass, "<init>", "(Ljava/util/jar/Manifest;)V");
			global::java.util.jar.Manifest._Manifest27896 = @__env.GetMethodIDNoThrow(global::java.util.jar.Manifest.staticClass, "<init>", "()V");
		}
	}
}
