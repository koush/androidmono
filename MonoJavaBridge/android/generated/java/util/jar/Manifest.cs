namespace java.util.jar
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class Manifest : java.lang.Object, java.lang.Cloneable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected Manifest(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override bool equals(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.jar.Manifest.staticClass, "equals", "(Ljava/lang/Object;)Z", ref global::java.util.jar.Manifest._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override int hashCode()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.jar.Manifest.staticClass, "hashCode", "()I", ref global::java.util.jar.Manifest._m1);
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual global::java.lang.Object clone()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.jar.Manifest.staticClass, "clone", "()Ljava/lang/Object;", ref global::java.util.jar.Manifest._m2) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual void clear()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.jar.Manifest.staticClass, "clear", "()V", ref global::java.util.jar.Manifest._m3);
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual void write(java.io.OutputStream arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.jar.Manifest.staticClass, "write", "(Ljava/io/OutputStream;)V", ref global::java.util.jar.Manifest._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual void read(java.io.InputStream arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.jar.Manifest.staticClass, "read", "(Ljava/io/InputStream;)V", ref global::java.util.jar.Manifest._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public virtual global::java.util.jar.Attributes getAttributes(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.jar.Manifest.staticClass, "getAttributes", "(Ljava/lang/String;)Ljava/util/jar/Attributes;", ref global::java.util.jar.Manifest._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.util.jar.Attributes;
		}
		public new global::java.util.jar.Attributes MainAttributes
		{
			get
			{
				return getMainAttributes();
			}
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public virtual global::java.util.jar.Attributes getMainAttributes()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.jar.Manifest.staticClass, "getMainAttributes", "()Ljava/util/jar/Attributes;", ref global::java.util.jar.Manifest._m7) as java.util.jar.Attributes;
		}
		public new global::java.util.Map Entries
		{
			get
			{
				return getEntries();
			}
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public virtual global::java.util.Map getEntries()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Map>(this, global::java.util.jar.Manifest.staticClass, "getEntries", "()Ljava/util/Map;", ref global::java.util.jar.Manifest._m8) as java.util.Map;
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public Manifest(java.io.InputStream arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.jar.Manifest._m9.native == global::System.IntPtr.Zero)
				global::java.util.jar.Manifest._m9 = @__env.GetMethodIDNoThrow(global::java.util.jar.Manifest.staticClass, "<init>", "(Ljava/io/InputStream;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.jar.Manifest.staticClass, global::java.util.jar.Manifest._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public Manifest(java.util.jar.Manifest arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.jar.Manifest._m10.native == global::System.IntPtr.Zero)
				global::java.util.jar.Manifest._m10 = @__env.GetMethodIDNoThrow(global::java.util.jar.Manifest.staticClass, "<init>", "(Ljava/util/jar/Manifest;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.jar.Manifest.staticClass, global::java.util.jar.Manifest._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public Manifest() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.jar.Manifest._m11.native == global::System.IntPtr.Zero)
				global::java.util.jar.Manifest._m11 = @__env.GetMethodIDNoThrow(global::java.util.jar.Manifest.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.jar.Manifest.staticClass, global::java.util.jar.Manifest._m11);
			Init(@__env, handle);
		}
		static Manifest()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.jar.Manifest.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/jar/Manifest"));
		}
	}
}
