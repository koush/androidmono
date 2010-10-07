namespace java.util
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public sealed class UUID : java.lang.Object, java.io.Serializable, java.lang.Comparable
	{
		internal static global::java.lang.Class staticClass;
		static UUID()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::java.util.UUID), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::java.util.UUID(@__env);
			}
		}
		internal UUID(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _equals13848;
		public sealed override bool equals(java.lang.Object arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::java.util.UUID._equals13848, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::java.util.UUID.staticClass, global::java.util.UUID._equals13848, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _toString13849;
		public sealed override global::java.lang.String toString() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::java.util.UUID._toString13849));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.util.UUID.staticClass, global::java.util.UUID._toString13849));
		}
		internal static global::net.sf.jni4net.jni.MethodId _hashCode13850;
		public sealed override int hashCode() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::java.util.UUID._hashCode13850);
			else
				return @__env.CallNonVirtualIntMethod(this, global::java.util.UUID.staticClass, global::java.util.UUID._hashCode13850);
		}
		internal static global::net.sf.jni4net.jni.MethodId _compareTo13851;
		public int compareTo(java.util.UUID arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::java.util.UUID._compareTo13851, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this, global::java.util.UUID.staticClass, global::java.util.UUID._compareTo13851, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _compareTo13852;
		public int compareTo(java.lang.Object arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::java.util.UUID._compareTo13852, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				return @__env.CallNonVirtualIntMethod(this, global::java.util.UUID.staticClass, global::java.util.UUID._compareTo13852, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _timestamp13853;
		public long timestamp() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this, global::java.util.UUID._timestamp13853);
			else
				return @__env.CallNonVirtualLongMethod(this, global::java.util.UUID.staticClass, global::java.util.UUID._timestamp13853);
		}
		internal static global::net.sf.jni4net.jni.MethodId _variant13854;
		public int variant() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::java.util.UUID._variant13854);
			else
				return @__env.CallNonVirtualIntMethod(this, global::java.util.UUID.staticClass, global::java.util.UUID._variant13854);
		}
		internal static global::net.sf.jni4net.jni.MethodId _version13855;
		public int version() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::java.util.UUID._version13855);
			else
				return @__env.CallNonVirtualIntMethod(this, global::java.util.UUID.staticClass, global::java.util.UUID._version13855);
		}
		internal static global::net.sf.jni4net.jni.MethodId _node13856;
		public long node() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this, global::java.util.UUID._node13856);
			else
				return @__env.CallNonVirtualLongMethod(this, global::java.util.UUID.staticClass, global::java.util.UUID._node13856);
		}
		internal static global::net.sf.jni4net.jni.MethodId _randomUUID13857;
		public static global::java.util.UUID randomUUID() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.util.UUID>(@__env, @__env.CallStaticObjectMethodPtr(java.util.UUID.staticClass, global::java.util.UUID._randomUUID13857));
		}
		internal static global::net.sf.jni4net.jni.MethodId _nameUUIDFromBytes13858;
		public static global::java.util.UUID nameUUIDFromBytes(byte[] arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.util.UUID>(@__env, @__env.CallStaticObjectMethodPtr(java.util.UUID.staticClass, global::java.util.UUID._nameUUIDFromBytes13858, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _fromString13859;
		public static global::java.util.UUID fromString(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.util.UUID>(@__env, @__env.CallStaticObjectMethodPtr(java.util.UUID.staticClass, global::java.util.UUID._fromString13859, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getLeastSignificantBits13860;
		public long getLeastSignificantBits() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this, global::java.util.UUID._getLeastSignificantBits13860);
			else
				return @__env.CallNonVirtualLongMethod(this, global::java.util.UUID.staticClass, global::java.util.UUID._getLeastSignificantBits13860);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getMostSignificantBits13861;
		public long getMostSignificantBits() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this, global::java.util.UUID._getMostSignificantBits13861);
			else
				return @__env.CallNonVirtualLongMethod(this, global::java.util.UUID.staticClass, global::java.util.UUID._getMostSignificantBits13861);
		}
		internal static global::net.sf.jni4net.jni.MethodId _clockSequence13862;
		public int clockSequence() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::java.util.UUID._clockSequence13862);
			else
				return @__env.CallNonVirtualIntMethod(this, global::java.util.UUID.staticClass, global::java.util.UUID._clockSequence13862);
		}
		internal static global::net.sf.jni4net.jni.MethodId _UUID13863;
		public UUID(long arg0, long arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(java.util.UUID.staticClass, global::java.util.UUID._UUID13863, this, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::java.util.UUID.staticClass = @__class;
			global::java.util.UUID._equals13848 = @__env.GetMethodID(global::java.util.UUID.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.util.UUID._toString13849 = @__env.GetMethodID(global::java.util.UUID.staticClass, "toString", "()Ljava/lang/String;");
			global::java.util.UUID._hashCode13850 = @__env.GetMethodID(global::java.util.UUID.staticClass, "hashCode", "()I");
			global::java.util.UUID._compareTo13851 = @__env.GetMethodID(global::java.util.UUID.staticClass, "compareTo", "(Ljava/util/UUID;)I");
			global::java.util.UUID._compareTo13852 = @__env.GetMethodID(global::java.util.UUID.staticClass, "compareTo", "(Ljava/lang/Object;)I");
			global::java.util.UUID._timestamp13853 = @__env.GetMethodID(global::java.util.UUID.staticClass, "timestamp", "()J");
			global::java.util.UUID._variant13854 = @__env.GetMethodID(global::java.util.UUID.staticClass, "variant", "()I");
			global::java.util.UUID._version13855 = @__env.GetMethodID(global::java.util.UUID.staticClass, "version", "()I");
			global::java.util.UUID._node13856 = @__env.GetMethodID(global::java.util.UUID.staticClass, "node", "()J");
			global::java.util.UUID._randomUUID13857 = @__env.GetStaticMethodID(global::java.util.UUID.staticClass, "randomUUID", "()Ljava/util/UUID;");
			global::java.util.UUID._nameUUIDFromBytes13858 = @__env.GetStaticMethodID(global::java.util.UUID.staticClass, "nameUUIDFromBytes", "([B)Ljava/util/UUID;");
			global::java.util.UUID._fromString13859 = @__env.GetStaticMethodID(global::java.util.UUID.staticClass, "fromString", "(Ljava/lang/String;)Ljava/util/UUID;");
			global::java.util.UUID._getLeastSignificantBits13860 = @__env.GetMethodID(global::java.util.UUID.staticClass, "getLeastSignificantBits", "()J");
			global::java.util.UUID._getMostSignificantBits13861 = @__env.GetMethodID(global::java.util.UUID.staticClass, "getMostSignificantBits", "()J");
			global::java.util.UUID._clockSequence13862 = @__env.GetMethodID(global::java.util.UUID.staticClass, "clockSequence", "()I");
			global::java.util.UUID._UUID13863 = @__env.GetMethodID(global::java.util.UUID.staticClass, "<init>", "(JJ)V");
		}
	}
}
