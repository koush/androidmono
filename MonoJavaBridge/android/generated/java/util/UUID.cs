namespace java.util
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class UUID : java.lang.Object, java.io.Serializable, java.lang.Comparable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal UUID(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _equals26941;
		public sealed override bool equals(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.UUID.staticClass, "equals", "(Ljava/lang/Object;)Z", ref global::java.util.UUID._equals26941, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString26942;
		public sealed override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.util.UUID.staticClass, "toString", "()Ljava/lang/String;", ref global::java.util.UUID._toString26942) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode26943;
		public sealed override int hashCode()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.UUID.staticClass, "hashCode", "()I", ref global::java.util.UUID._hashCode26943);
		}
		internal static global::MonoJavaBridge.MethodId _compareTo26944;
		public int compareTo(java.util.UUID arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.UUID.staticClass, "compareTo", "(Ljava/util/UUID;)I", ref global::java.util.UUID._compareTo26944, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _compareTo26945;
		public int compareTo(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.UUID.staticClass, "compareTo", "(Ljava/lang/Object;)I", ref global::java.util.UUID._compareTo26945, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _timestamp26946;
		public long timestamp()
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::java.util.UUID.staticClass, "timestamp", "()J", ref global::java.util.UUID._timestamp26946);
		}
		internal static global::MonoJavaBridge.MethodId _variant26947;
		public int variant()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.UUID.staticClass, "variant", "()I", ref global::java.util.UUID._variant26947);
		}
		internal static global::MonoJavaBridge.MethodId _version26948;
		public int version()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.UUID.staticClass, "version", "()I", ref global::java.util.UUID._version26948);
		}
		internal static global::MonoJavaBridge.MethodId _node26949;
		public long node()
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::java.util.UUID.staticClass, "node", "()J", ref global::java.util.UUID._node26949);
		}
		internal static global::MonoJavaBridge.MethodId _randomUUID26950;
		public static global::java.util.UUID randomUUID()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.UUID._randomUUID26950.native == global::System.IntPtr.Zero)
				global::java.util.UUID._randomUUID26950 = @__env.GetStaticMethodIDNoThrow(global::java.util.UUID.staticClass, "randomUUID", "()Ljava/util/UUID;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.util.UUID>(@__env.CallStaticObjectMethod(java.util.UUID.staticClass, global::java.util.UUID._randomUUID26950)) as java.util.UUID;
		}
		internal static global::MonoJavaBridge.MethodId _nameUUIDFromBytes26951;
		public static global::java.util.UUID nameUUIDFromBytes(byte[] arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.UUID._nameUUIDFromBytes26951.native == global::System.IntPtr.Zero)
				global::java.util.UUID._nameUUIDFromBytes26951 = @__env.GetStaticMethodIDNoThrow(global::java.util.UUID.staticClass, "nameUUIDFromBytes", "([B)Ljava/util/UUID;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.util.UUID>(@__env.CallStaticObjectMethod(java.util.UUID.staticClass, global::java.util.UUID._nameUUIDFromBytes26951, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.UUID;
		}
		internal static global::MonoJavaBridge.MethodId _fromString26952;
		public static global::java.util.UUID fromString(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.UUID._fromString26952.native == global::System.IntPtr.Zero)
				global::java.util.UUID._fromString26952 = @__env.GetStaticMethodIDNoThrow(global::java.util.UUID.staticClass, "fromString", "(Ljava/lang/String;)Ljava/util/UUID;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.util.UUID>(@__env.CallStaticObjectMethod(java.util.UUID.staticClass, global::java.util.UUID._fromString26952, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.UUID;
		}
		public new long LeastSignificantBits
		{
			get
			{
				return getLeastSignificantBits();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getLeastSignificantBits26953;
		public long getLeastSignificantBits()
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::java.util.UUID.staticClass, "getLeastSignificantBits", "()J", ref global::java.util.UUID._getLeastSignificantBits26953);
		}
		public new long MostSignificantBits
		{
			get
			{
				return getMostSignificantBits();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getMostSignificantBits26954;
		public long getMostSignificantBits()
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::java.util.UUID.staticClass, "getMostSignificantBits", "()J", ref global::java.util.UUID._getMostSignificantBits26954);
		}
		internal static global::MonoJavaBridge.MethodId _clockSequence26955;
		public int clockSequence()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.UUID.staticClass, "clockSequence", "()I", ref global::java.util.UUID._clockSequence26955);
		}
		internal static global::MonoJavaBridge.MethodId _UUID26956;
		public UUID(long arg0, long arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.UUID._UUID26956.native == global::System.IntPtr.Zero)
				global::java.util.UUID._UUID26956 = @__env.GetMethodIDNoThrow(global::java.util.UUID.staticClass, "<init>", "(JJ)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.UUID.staticClass, global::java.util.UUID._UUID26956, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		static UUID()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.UUID.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/UUID"));
		}
		internal static void InitJNI()
		{
		}
	}
}
