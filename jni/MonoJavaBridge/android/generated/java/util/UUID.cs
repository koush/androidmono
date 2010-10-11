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
		internal static global::MonoJavaBridge.MethodId _equals15712;
		public sealed override bool equals(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.UUID._equals15712, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.UUID.staticClass, global::java.util.UUID._equals15712, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString15713;
		public sealed override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.UUID._toString15713)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.UUID.staticClass, global::java.util.UUID._toString15713)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode15714;
		public sealed override int hashCode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.UUID._hashCode15714);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.UUID.staticClass, global::java.util.UUID._hashCode15714);
		}
		internal static global::MonoJavaBridge.MethodId _compareTo15715;
		public int compareTo(java.util.UUID arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.UUID._compareTo15715, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.UUID.staticClass, global::java.util.UUID._compareTo15715, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _compareTo15716;
		public int compareTo(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.UUID._compareTo15716, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.UUID.staticClass, global::java.util.UUID._compareTo15716, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _timestamp15717;
		public long timestamp() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.util.UUID._timestamp15717);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.util.UUID.staticClass, global::java.util.UUID._timestamp15717);
		}
		internal static global::MonoJavaBridge.MethodId _variant15718;
		public int variant() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.UUID._variant15718);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.UUID.staticClass, global::java.util.UUID._variant15718);
		}
		internal static global::MonoJavaBridge.MethodId _version15719;
		public int version() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.UUID._version15719);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.UUID.staticClass, global::java.util.UUID._version15719);
		}
		internal static global::MonoJavaBridge.MethodId _node15720;
		public long node() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.util.UUID._node15720);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.util.UUID.staticClass, global::java.util.UUID._node15720);
		}
		internal static global::MonoJavaBridge.MethodId _randomUUID15721;
		public static global::java.util.UUID randomUUID() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.util.UUID.staticClass, global::java.util.UUID._randomUUID15721)) as java.util.UUID;
		}
		internal static global::MonoJavaBridge.MethodId _nameUUIDFromBytes15722;
		public static global::java.util.UUID nameUUIDFromBytes(byte[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.util.UUID.staticClass, global::java.util.UUID._nameUUIDFromBytes15722, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.UUID;
		}
		internal static global::MonoJavaBridge.MethodId _fromString15723;
		public static global::java.util.UUID fromString(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.util.UUID.staticClass, global::java.util.UUID._fromString15723, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.UUID;
		}
		internal static global::MonoJavaBridge.MethodId _getLeastSignificantBits15724;
		public long getLeastSignificantBits() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.util.UUID._getLeastSignificantBits15724);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.util.UUID.staticClass, global::java.util.UUID._getLeastSignificantBits15724);
		}
		internal static global::MonoJavaBridge.MethodId _getMostSignificantBits15725;
		public long getMostSignificantBits() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.util.UUID._getMostSignificantBits15725);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.util.UUID.staticClass, global::java.util.UUID._getMostSignificantBits15725);
		}
		internal static global::MonoJavaBridge.MethodId _clockSequence15726;
		public int clockSequence() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.UUID._clockSequence15726);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.UUID.staticClass, global::java.util.UUID._clockSequence15726);
		}
		internal static global::MonoJavaBridge.MethodId _UUID15727;
		public UUID(long arg0, long arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.UUID.staticClass, global::java.util.UUID._UUID15727, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.UUID.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/UUID"));
			global::java.util.UUID._equals15712 = @__env.GetMethodIDNoThrow(global::java.util.UUID.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.util.UUID._toString15713 = @__env.GetMethodIDNoThrow(global::java.util.UUID.staticClass, "toString", "()Ljava/lang/String;");
			global::java.util.UUID._hashCode15714 = @__env.GetMethodIDNoThrow(global::java.util.UUID.staticClass, "hashCode", "()I");
			global::java.util.UUID._compareTo15715 = @__env.GetMethodIDNoThrow(global::java.util.UUID.staticClass, "compareTo", "(Ljava/util/UUID;)I");
			global::java.util.UUID._compareTo15716 = @__env.GetMethodIDNoThrow(global::java.util.UUID.staticClass, "compareTo", "(Ljava/lang/Object;)I");
			global::java.util.UUID._timestamp15717 = @__env.GetMethodIDNoThrow(global::java.util.UUID.staticClass, "timestamp", "()J");
			global::java.util.UUID._variant15718 = @__env.GetMethodIDNoThrow(global::java.util.UUID.staticClass, "variant", "()I");
			global::java.util.UUID._version15719 = @__env.GetMethodIDNoThrow(global::java.util.UUID.staticClass, "version", "()I");
			global::java.util.UUID._node15720 = @__env.GetMethodIDNoThrow(global::java.util.UUID.staticClass, "node", "()J");
			global::java.util.UUID._randomUUID15721 = @__env.GetStaticMethodIDNoThrow(global::java.util.UUID.staticClass, "randomUUID", "()Ljava/util/UUID;");
			global::java.util.UUID._nameUUIDFromBytes15722 = @__env.GetStaticMethodIDNoThrow(global::java.util.UUID.staticClass, "nameUUIDFromBytes", "([B)Ljava/util/UUID;");
			global::java.util.UUID._fromString15723 = @__env.GetStaticMethodIDNoThrow(global::java.util.UUID.staticClass, "fromString", "(Ljava/lang/String;)Ljava/util/UUID;");
			global::java.util.UUID._getLeastSignificantBits15724 = @__env.GetMethodIDNoThrow(global::java.util.UUID.staticClass, "getLeastSignificantBits", "()J");
			global::java.util.UUID._getMostSignificantBits15725 = @__env.GetMethodIDNoThrow(global::java.util.UUID.staticClass, "getMostSignificantBits", "()J");
			global::java.util.UUID._clockSequence15726 = @__env.GetMethodIDNoThrow(global::java.util.UUID.staticClass, "clockSequence", "()I");
			global::java.util.UUID._UUID15727 = @__env.GetMethodIDNoThrow(global::java.util.UUID.staticClass, "<init>", "(JJ)V");
		}
	}
}
