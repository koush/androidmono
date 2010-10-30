namespace java.lang
{
	[global::MonoJavaBridge.JavaClass(typeof(global::java.lang.Enum_))]
	public abstract partial class Enum : java.lang.Object, Comparable, java.io.Serializable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected Enum(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual global::java.lang.String name()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.lang.Enum.staticClass, "name", "()Ljava/lang/String;", ref global::java.lang.Enum._m0) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		protected sealed override void finalize()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.lang.Enum.staticClass, "finalize", "()V", ref global::java.lang.Enum._m1);
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public sealed override bool equals(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.lang.Enum.staticClass, "equals", "(Ljava/lang/Object;)Z", ref global::java.lang.Enum._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.lang.Enum.staticClass, "toString", "()Ljava/lang/String;", ref global::java.lang.Enum._m3) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public sealed override int hashCode()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.lang.Enum.staticClass, "hashCode", "()I", ref global::java.lang.Enum._m4);
		}
		private static global::MonoJavaBridge.MethodId _m5;
		protected sealed override global::java.lang.Object clone()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.lang.Enum.staticClass, "clone", "()Ljava/lang/Object;", ref global::java.lang.Enum._m5) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public virtual int compareTo(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.lang.Enum.staticClass, "compareTo", "(Ljava/lang/Object;)I", ref global::java.lang.Enum._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public virtual int compareTo(java.lang.Enum arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.lang.Enum.staticClass, "compareTo", "(Ljava/lang/Enum;)I", ref global::java.lang.Enum._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public static global::java.lang.Enum valueOf(java.lang.Class arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Enum._m8.native == global::System.IntPtr.Zero)
				global::java.lang.Enum._m8 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Enum.staticClass, "valueOf", "(Ljava/lang/Class;Ljava/lang/String;)Ljava/lang/Enum;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.lang.Enum.staticClass, global::java.lang.Enum._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Enum;
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public virtual global::java.lang.Class getDeclaringClass()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.Class>(this, global::java.lang.Enum.staticClass, "getDeclaringClass", "()Ljava/lang/Class;", ref global::java.lang.Enum._m9) as java.lang.Class;
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public virtual int ordinal()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.lang.Enum.staticClass, "ordinal", "()I", ref global::java.lang.Enum._m10);
		}
		private static global::MonoJavaBridge.MethodId _m11;
		protected Enum(java.lang.String arg0, int arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Enum._m11.native == global::System.IntPtr.Zero)
				global::java.lang.Enum._m11 = @__env.GetMethodIDNoThrow(global::java.lang.Enum.staticClass, "<init>", "(Ljava/lang/String;I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.Enum.staticClass, global::java.lang.Enum._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		static Enum()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.Enum.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/Enum"));
		}
		internal static void InitJNI()
		{
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.lang.Enum))]
	internal sealed partial class Enum_ : java.lang.Enum
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal Enum_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		static Enum_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.Enum_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/Enum"));
		}
		internal static void InitJNI()
		{
		}
	}
}
