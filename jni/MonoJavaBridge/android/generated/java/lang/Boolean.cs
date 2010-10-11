namespace java.lang
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class Boolean : java.lang.Object, java.io.Serializable, Comparable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Boolean()
		{
			InitJNI();
		}
		internal Boolean(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _equals12787;
		public sealed override bool equals(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.lang.Boolean._equals12787, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.lang.Boolean.staticClass, global::java.lang.Boolean._equals12787, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString12788;
		public sealed override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.Boolean._toString12788)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.Boolean.staticClass, global::java.lang.Boolean._toString12788)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _toString12789;
		public static global::java.lang.String toString(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.lang.Boolean.staticClass, global::java.lang.Boolean._toString12789, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode12790;
		public sealed override int hashCode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.lang.Boolean._hashCode12790);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.lang.Boolean.staticClass, global::java.lang.Boolean._hashCode12790);
		}
		internal static global::MonoJavaBridge.MethodId _compareTo12791;
		public int compareTo(java.lang.Boolean arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.lang.Boolean._compareTo12791, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.lang.Boolean.staticClass, global::java.lang.Boolean._compareTo12791, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _compareTo12792;
		public int compareTo(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.lang.Boolean._compareTo12792, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.lang.Boolean.staticClass, global::java.lang.Boolean._compareTo12792, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getBoolean12793;
		public static bool getBoolean(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(java.lang.Boolean.staticClass, global::java.lang.Boolean._getBoolean12793, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _valueOf12794;
		public static global::java.lang.Boolean valueOf(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.lang.Boolean.staticClass, global::java.lang.Boolean._valueOf12794, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Boolean;
		}
		internal static global::MonoJavaBridge.MethodId _valueOf12795;
		public static global::java.lang.Boolean valueOf(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.lang.Boolean.staticClass, global::java.lang.Boolean._valueOf12795, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Boolean;
		}
		internal static global::MonoJavaBridge.MethodId _booleanValue12796;
		public bool booleanValue() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.lang.Boolean._booleanValue12796);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.lang.Boolean.staticClass, global::java.lang.Boolean._booleanValue12796);
		}
		internal static global::MonoJavaBridge.MethodId _parseBoolean12797;
		public static bool parseBoolean(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(java.lang.Boolean.staticClass, global::java.lang.Boolean._parseBoolean12797, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _Boolean12798;
		public Boolean(bool arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.Boolean.staticClass, global::java.lang.Boolean._Boolean12798, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Boolean12799;
		public Boolean(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.Boolean.staticClass, global::java.lang.Boolean._Boolean12799, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _TRUE12800;
		public static global::java.lang.Boolean TRUE
		{
			get
			{
				return default(global::java.lang.Boolean);
			}
		}
		internal static global::MonoJavaBridge.FieldId _FALSE12801;
		public static global::java.lang.Boolean FALSE
		{
			get
			{
				return default(global::java.lang.Boolean);
			}
		}
		internal static global::MonoJavaBridge.FieldId _TYPE12802;
		public static global::java.lang.Class TYPE
		{
			get
			{
				return default(global::java.lang.Class);
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.Boolean.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/Boolean"));
			global::java.lang.Boolean._equals12787 = @__env.GetMethodIDNoThrow(global::java.lang.Boolean.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.lang.Boolean._toString12788 = @__env.GetMethodIDNoThrow(global::java.lang.Boolean.staticClass, "toString", "()Ljava/lang/String;");
			global::java.lang.Boolean._toString12789 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Boolean.staticClass, "toString", "(Z)Ljava/lang/String;");
			global::java.lang.Boolean._hashCode12790 = @__env.GetMethodIDNoThrow(global::java.lang.Boolean.staticClass, "hashCode", "()I");
			global::java.lang.Boolean._compareTo12791 = @__env.GetMethodIDNoThrow(global::java.lang.Boolean.staticClass, "compareTo", "(Ljava/lang/Boolean;)I");
			global::java.lang.Boolean._compareTo12792 = @__env.GetMethodIDNoThrow(global::java.lang.Boolean.staticClass, "compareTo", "(Ljava/lang/Object;)I");
			global::java.lang.Boolean._getBoolean12793 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Boolean.staticClass, "getBoolean", "(Ljava/lang/String;)Z");
			global::java.lang.Boolean._valueOf12794 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Boolean.staticClass, "valueOf", "(Z)Ljava/lang/Boolean;");
			global::java.lang.Boolean._valueOf12795 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Boolean.staticClass, "valueOf", "(Ljava/lang/String;)Ljava/lang/Boolean;");
			global::java.lang.Boolean._booleanValue12796 = @__env.GetMethodIDNoThrow(global::java.lang.Boolean.staticClass, "booleanValue", "()Z");
			global::java.lang.Boolean._parseBoolean12797 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Boolean.staticClass, "parseBoolean", "(Ljava/lang/String;)Z");
			global::java.lang.Boolean._Boolean12798 = @__env.GetMethodIDNoThrow(global::java.lang.Boolean.staticClass, "<init>", "(Z)V");
			global::java.lang.Boolean._Boolean12799 = @__env.GetMethodIDNoThrow(global::java.lang.Boolean.staticClass, "<init>", "(Ljava/lang/String;)V");
		}
	}
}
