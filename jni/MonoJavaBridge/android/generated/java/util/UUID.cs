namespace java.util
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class UUID : java.lang.Object, java.io.Serializable, java.lang.Comparable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static UUID()
		{
			InitJNI();
		}
		internal UUID(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _equals20992;
		public sealed override bool equals(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.UUID._equals20992, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.UUID.staticClass, global::java.util.UUID._equals20992, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString20993;
		public sealed override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.UUID._toString20993)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.UUID.staticClass, global::java.util.UUID._toString20993)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode20994;
		public sealed override int hashCode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.UUID._hashCode20994);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.UUID.staticClass, global::java.util.UUID._hashCode20994);
		}
		internal static global::MonoJavaBridge.MethodId _compareTo20995;
		public int compareTo(java.util.UUID arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.UUID._compareTo20995, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.UUID.staticClass, global::java.util.UUID._compareTo20995, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _compareTo20996;
		public int compareTo(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.UUID._compareTo20996, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.UUID.staticClass, global::java.util.UUID._compareTo20996, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _timestamp20997;
		public long timestamp() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.util.UUID._timestamp20997);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.util.UUID.staticClass, global::java.util.UUID._timestamp20997);
		}
		internal static global::MonoJavaBridge.MethodId _variant20998;
		public int variant() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.UUID._variant20998);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.UUID.staticClass, global::java.util.UUID._variant20998);
		}
		internal static global::MonoJavaBridge.MethodId _version20999;
		public int version() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.UUID._version20999);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.UUID.staticClass, global::java.util.UUID._version20999);
		}
		internal static global::MonoJavaBridge.MethodId _node21000;
		public long node() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.util.UUID._node21000);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.util.UUID.staticClass, global::java.util.UUID._node21000);
		}
		internal static global::MonoJavaBridge.MethodId _randomUUID21001;
		public static global::java.util.UUID randomUUID() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.util.UUID.staticClass, global::java.util.UUID._randomUUID21001)) as java.util.UUID;
		}
		internal static global::MonoJavaBridge.MethodId _nameUUIDFromBytes21002;
		public static global::java.util.UUID nameUUIDFromBytes(byte[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.util.UUID.staticClass, global::java.util.UUID._nameUUIDFromBytes21002, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.UUID;
		}
		internal static global::MonoJavaBridge.MethodId _fromString21003;
		public static global::java.util.UUID fromString(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.util.UUID.staticClass, global::java.util.UUID._fromString21003, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.UUID;
		}
		public new long LeastSignificantBits
		{
			get
			{
				return getLeastSignificantBits();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getLeastSignificantBits21004;
		public long getLeastSignificantBits() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.util.UUID._getLeastSignificantBits21004);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.util.UUID.staticClass, global::java.util.UUID._getLeastSignificantBits21004);
		}
		public new long MostSignificantBits
		{
			get
			{
				return getMostSignificantBits();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getMostSignificantBits21005;
		public long getMostSignificantBits() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.util.UUID._getMostSignificantBits21005);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.util.UUID.staticClass, global::java.util.UUID._getMostSignificantBits21005);
		}
		internal static global::MonoJavaBridge.MethodId _clockSequence21006;
		public int clockSequence() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.UUID._clockSequence21006);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.UUID.staticClass, global::java.util.UUID._clockSequence21006);
		}
		internal static global::MonoJavaBridge.MethodId _UUID21007;
		public UUID(long arg0, long arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.UUID.staticClass, global::java.util.UUID._UUID21007, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.UUID.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/UUID"));
			global::java.util.UUID._equals20992 = @__env.GetMethodIDNoThrow(global::java.util.UUID.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.util.UUID._toString20993 = @__env.GetMethodIDNoThrow(global::java.util.UUID.staticClass, "toString", "()Ljava/lang/String;");
			global::java.util.UUID._hashCode20994 = @__env.GetMethodIDNoThrow(global::java.util.UUID.staticClass, "hashCode", "()I");
			global::java.util.UUID._compareTo20995 = @__env.GetMethodIDNoThrow(global::java.util.UUID.staticClass, "compareTo", "(Ljava/util/UUID;)I");
			global::java.util.UUID._compareTo20996 = @__env.GetMethodIDNoThrow(global::java.util.UUID.staticClass, "compareTo", "(Ljava/lang/Object;)I");
			global::java.util.UUID._timestamp20997 = @__env.GetMethodIDNoThrow(global::java.util.UUID.staticClass, "timestamp", "()J");
			global::java.util.UUID._variant20998 = @__env.GetMethodIDNoThrow(global::java.util.UUID.staticClass, "variant", "()I");
			global::java.util.UUID._version20999 = @__env.GetMethodIDNoThrow(global::java.util.UUID.staticClass, "version", "()I");
			global::java.util.UUID._node21000 = @__env.GetMethodIDNoThrow(global::java.util.UUID.staticClass, "node", "()J");
			global::java.util.UUID._randomUUID21001 = @__env.GetStaticMethodIDNoThrow(global::java.util.UUID.staticClass, "randomUUID", "()Ljava/util/UUID;");
			global::java.util.UUID._nameUUIDFromBytes21002 = @__env.GetStaticMethodIDNoThrow(global::java.util.UUID.staticClass, "nameUUIDFromBytes", "([B)Ljava/util/UUID;");
			global::java.util.UUID._fromString21003 = @__env.GetStaticMethodIDNoThrow(global::java.util.UUID.staticClass, "fromString", "(Ljava/lang/String;)Ljava/util/UUID;");
			global::java.util.UUID._getLeastSignificantBits21004 = @__env.GetMethodIDNoThrow(global::java.util.UUID.staticClass, "getLeastSignificantBits", "()J");
			global::java.util.UUID._getMostSignificantBits21005 = @__env.GetMethodIDNoThrow(global::java.util.UUID.staticClass, "getMostSignificantBits", "()J");
			global::java.util.UUID._clockSequence21006 = @__env.GetMethodIDNoThrow(global::java.util.UUID.staticClass, "clockSequence", "()I");
			global::java.util.UUID._UUID21007 = @__env.GetMethodIDNoThrow(global::java.util.UUID.staticClass, "<init>", "(JJ)V");
		}
	}
}
