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
		internal static global::MonoJavaBridge.MethodId _equals26822;
		public sealed override bool equals(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.UUID._equals26822, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.UUID.staticClass, global::java.util.UUID._equals26822, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString26823;
		public sealed override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.UUID._toString26823)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.UUID.staticClass, global::java.util.UUID._toString26823)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode26824;
		public sealed override int hashCode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.UUID._hashCode26824);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.UUID.staticClass, global::java.util.UUID._hashCode26824);
		}
		internal static global::MonoJavaBridge.MethodId _compareTo26825;
		public int compareTo(java.util.UUID arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.UUID._compareTo26825, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.UUID.staticClass, global::java.util.UUID._compareTo26825, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _compareTo26826;
		public int compareTo(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.UUID._compareTo26826, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.UUID.staticClass, global::java.util.UUID._compareTo26826, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _timestamp26827;
		public long timestamp() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.util.UUID._timestamp26827);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.util.UUID.staticClass, global::java.util.UUID._timestamp26827);
		}
		internal static global::MonoJavaBridge.MethodId _variant26828;
		public int variant() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.UUID._variant26828);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.UUID.staticClass, global::java.util.UUID._variant26828);
		}
		internal static global::MonoJavaBridge.MethodId _version26829;
		public int version() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.UUID._version26829);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.UUID.staticClass, global::java.util.UUID._version26829);
		}
		internal static global::MonoJavaBridge.MethodId _node26830;
		public long node() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.util.UUID._node26830);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.util.UUID.staticClass, global::java.util.UUID._node26830);
		}
		internal static global::MonoJavaBridge.MethodId _randomUUID26831;
		public static global::java.util.UUID randomUUID() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.util.UUID.staticClass, global::java.util.UUID._randomUUID26831)) as java.util.UUID;
		}
		internal static global::MonoJavaBridge.MethodId _nameUUIDFromBytes26832;
		public static global::java.util.UUID nameUUIDFromBytes(byte[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.util.UUID.staticClass, global::java.util.UUID._nameUUIDFromBytes26832, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.UUID;
		}
		internal static global::MonoJavaBridge.MethodId _fromString26833;
		public static global::java.util.UUID fromString(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.util.UUID.staticClass, global::java.util.UUID._fromString26833, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.UUID;
		}
		public new long LeastSignificantBits
		{
			get
			{
				return getLeastSignificantBits();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getLeastSignificantBits26834;
		public long getLeastSignificantBits() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.util.UUID._getLeastSignificantBits26834);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.util.UUID.staticClass, global::java.util.UUID._getLeastSignificantBits26834);
		}
		public new long MostSignificantBits
		{
			get
			{
				return getMostSignificantBits();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getMostSignificantBits26835;
		public long getMostSignificantBits() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.util.UUID._getMostSignificantBits26835);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.util.UUID.staticClass, global::java.util.UUID._getMostSignificantBits26835);
		}
		internal static global::MonoJavaBridge.MethodId _clockSequence26836;
		public int clockSequence() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.UUID._clockSequence26836);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.UUID.staticClass, global::java.util.UUID._clockSequence26836);
		}
		internal static global::MonoJavaBridge.MethodId _UUID26837;
		public UUID(long arg0, long arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.UUID.staticClass, global::java.util.UUID._UUID26837, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.UUID.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/UUID"));
			global::java.util.UUID._equals26822 = @__env.GetMethodIDNoThrow(global::java.util.UUID.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.util.UUID._toString26823 = @__env.GetMethodIDNoThrow(global::java.util.UUID.staticClass, "toString", "()Ljava/lang/String;");
			global::java.util.UUID._hashCode26824 = @__env.GetMethodIDNoThrow(global::java.util.UUID.staticClass, "hashCode", "()I");
			global::java.util.UUID._compareTo26825 = @__env.GetMethodIDNoThrow(global::java.util.UUID.staticClass, "compareTo", "(Ljava/util/UUID;)I");
			global::java.util.UUID._compareTo26826 = @__env.GetMethodIDNoThrow(global::java.util.UUID.staticClass, "compareTo", "(Ljava/lang/Object;)I");
			global::java.util.UUID._timestamp26827 = @__env.GetMethodIDNoThrow(global::java.util.UUID.staticClass, "timestamp", "()J");
			global::java.util.UUID._variant26828 = @__env.GetMethodIDNoThrow(global::java.util.UUID.staticClass, "variant", "()I");
			global::java.util.UUID._version26829 = @__env.GetMethodIDNoThrow(global::java.util.UUID.staticClass, "version", "()I");
			global::java.util.UUID._node26830 = @__env.GetMethodIDNoThrow(global::java.util.UUID.staticClass, "node", "()J");
			global::java.util.UUID._randomUUID26831 = @__env.GetStaticMethodIDNoThrow(global::java.util.UUID.staticClass, "randomUUID", "()Ljava/util/UUID;");
			global::java.util.UUID._nameUUIDFromBytes26832 = @__env.GetStaticMethodIDNoThrow(global::java.util.UUID.staticClass, "nameUUIDFromBytes", "([B)Ljava/util/UUID;");
			global::java.util.UUID._fromString26833 = @__env.GetStaticMethodIDNoThrow(global::java.util.UUID.staticClass, "fromString", "(Ljava/lang/String;)Ljava/util/UUID;");
			global::java.util.UUID._getLeastSignificantBits26834 = @__env.GetMethodIDNoThrow(global::java.util.UUID.staticClass, "getLeastSignificantBits", "()J");
			global::java.util.UUID._getMostSignificantBits26835 = @__env.GetMethodIDNoThrow(global::java.util.UUID.staticClass, "getMostSignificantBits", "()J");
			global::java.util.UUID._clockSequence26836 = @__env.GetMethodIDNoThrow(global::java.util.UUID.staticClass, "clockSequence", "()I");
			global::java.util.UUID._UUID26837 = @__env.GetMethodIDNoThrow(global::java.util.UUID.staticClass, "<init>", "(JJ)V");
		}
	}
}
