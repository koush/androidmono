namespace java.util
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class UUID : java.lang.Object, java.io.Serializable, java.lang.Comparable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal UUID(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public sealed override bool equals(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.UUID.staticClass, "equals", "(Ljava/lang/Object;)Z", ref global::java.util.UUID._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public sealed override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.util.UUID.staticClass, "toString", "()Ljava/lang/String;", ref global::java.util.UUID._m1) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public sealed override int hashCode()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.UUID.staticClass, "hashCode", "()I", ref global::java.util.UUID._m2);
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public int compareTo(java.util.UUID arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.UUID.staticClass, "compareTo", "(Ljava/util/UUID;)I", ref global::java.util.UUID._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public int compareTo(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.UUID.staticClass, "compareTo", "(Ljava/lang/Object;)I", ref global::java.util.UUID._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public long timestamp()
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::java.util.UUID.staticClass, "timestamp", "()J", ref global::java.util.UUID._m5);
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public int variant()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.UUID.staticClass, "variant", "()I", ref global::java.util.UUID._m6);
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public int version()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.UUID.staticClass, "version", "()I", ref global::java.util.UUID._m7);
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public long node()
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::java.util.UUID.staticClass, "node", "()J", ref global::java.util.UUID._m8);
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public static global::java.util.UUID randomUUID()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.UUID._m9.native == global::System.IntPtr.Zero)
				global::java.util.UUID._m9 = @__env.GetStaticMethodIDNoThrow(global::java.util.UUID.staticClass, "randomUUID", "()Ljava/util/UUID;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.util.UUID>(@__env.CallStaticObjectMethod(java.util.UUID.staticClass, global::java.util.UUID._m9)) as java.util.UUID;
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public static global::java.util.UUID nameUUIDFromBytes(byte[] arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.UUID._m10.native == global::System.IntPtr.Zero)
				global::java.util.UUID._m10 = @__env.GetStaticMethodIDNoThrow(global::java.util.UUID.staticClass, "nameUUIDFromBytes", "([B)Ljava/util/UUID;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.util.UUID>(@__env.CallStaticObjectMethod(java.util.UUID.staticClass, global::java.util.UUID._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.UUID;
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public static global::java.util.UUID fromString(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.UUID._m11.native == global::System.IntPtr.Zero)
				global::java.util.UUID._m11 = @__env.GetStaticMethodIDNoThrow(global::java.util.UUID.staticClass, "fromString", "(Ljava/lang/String;)Ljava/util/UUID;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.util.UUID>(@__env.CallStaticObjectMethod(java.util.UUID.staticClass, global::java.util.UUID._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.UUID;
		}
		public new long LeastSignificantBits
		{
			get
			{
				return getLeastSignificantBits();
			}
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public long getLeastSignificantBits()
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::java.util.UUID.staticClass, "getLeastSignificantBits", "()J", ref global::java.util.UUID._m12);
		}
		public new long MostSignificantBits
		{
			get
			{
				return getMostSignificantBits();
			}
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public long getMostSignificantBits()
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::java.util.UUID.staticClass, "getMostSignificantBits", "()J", ref global::java.util.UUID._m13);
		}
		private static global::MonoJavaBridge.MethodId _m14;
		public int clockSequence()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.UUID.staticClass, "clockSequence", "()I", ref global::java.util.UUID._m14);
		}
		private static global::MonoJavaBridge.MethodId _m15;
		public UUID(long arg0, long arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.UUID._m15.native == global::System.IntPtr.Zero)
				global::java.util.UUID._m15 = @__env.GetMethodIDNoThrow(global::java.util.UUID.staticClass, "<init>", "(JJ)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.UUID.staticClass, global::java.util.UUID._m15, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		static UUID()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.UUID.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/UUID"));
		}
	}
}
