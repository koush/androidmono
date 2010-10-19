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
		internal static global::MonoJavaBridge.MethodId _equals14101;
		public sealed override bool equals(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.lang.Boolean._equals14101, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.lang.Boolean.staticClass, global::java.lang.Boolean._equals14101, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString14102;
		public sealed override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.Boolean._toString14102)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.Boolean.staticClass, global::java.lang.Boolean._toString14102)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _toString14103;
		public static global::java.lang.String toString(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.lang.Boolean.staticClass, global::java.lang.Boolean._toString14103, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode14104;
		public sealed override int hashCode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.lang.Boolean._hashCode14104);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.lang.Boolean.staticClass, global::java.lang.Boolean._hashCode14104);
		}
		internal static global::MonoJavaBridge.MethodId _compareTo14105;
		public int compareTo(java.lang.Boolean arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.lang.Boolean._compareTo14105, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.lang.Boolean.staticClass, global::java.lang.Boolean._compareTo14105, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _compareTo14106;
		public int compareTo(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.lang.Boolean._compareTo14106, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.lang.Boolean.staticClass, global::java.lang.Boolean._compareTo14106, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getBoolean14107;
		public static bool getBoolean(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(java.lang.Boolean.staticClass, global::java.lang.Boolean._getBoolean14107, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _valueOf14108;
		public static global::java.lang.Boolean valueOf(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.lang.Boolean.staticClass, global::java.lang.Boolean._valueOf14108, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Boolean;
		}
		internal static global::MonoJavaBridge.MethodId _valueOf14109;
		public static global::java.lang.Boolean valueOf(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.lang.Boolean.staticClass, global::java.lang.Boolean._valueOf14109, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Boolean;
		}
		internal static global::MonoJavaBridge.MethodId _booleanValue14110;
		public bool booleanValue() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.lang.Boolean._booleanValue14110);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.lang.Boolean.staticClass, global::java.lang.Boolean._booleanValue14110);
		}
		internal static global::MonoJavaBridge.MethodId _parseBoolean14111;
		public static bool parseBoolean(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(java.lang.Boolean.staticClass, global::java.lang.Boolean._parseBoolean14111, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _Boolean14112;
		public Boolean(bool arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.Boolean.staticClass, global::java.lang.Boolean._Boolean14112, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Boolean14113;
		public Boolean(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.Boolean.staticClass, global::java.lang.Boolean._Boolean14113, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _TRUE14114;
		public static global::java.lang.Boolean TRUE
		{
			get
			{
				return default(global::java.lang.Boolean);
			}
		}
		internal static global::MonoJavaBridge.FieldId _FALSE14115;
		public static global::java.lang.Boolean FALSE
		{
			get
			{
				return default(global::java.lang.Boolean);
			}
		}
		internal static global::MonoJavaBridge.FieldId _TYPE14116;
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
			global::java.lang.Boolean._equals14101 = @__env.GetMethodIDNoThrow(global::java.lang.Boolean.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.lang.Boolean._toString14102 = @__env.GetMethodIDNoThrow(global::java.lang.Boolean.staticClass, "toString", "()Ljava/lang/String;");
			global::java.lang.Boolean._toString14103 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Boolean.staticClass, "toString", "(Z)Ljava/lang/String;");
			global::java.lang.Boolean._hashCode14104 = @__env.GetMethodIDNoThrow(global::java.lang.Boolean.staticClass, "hashCode", "()I");
			global::java.lang.Boolean._compareTo14105 = @__env.GetMethodIDNoThrow(global::java.lang.Boolean.staticClass, "compareTo", "(Ljava/lang/Boolean;)I");
			global::java.lang.Boolean._compareTo14106 = @__env.GetMethodIDNoThrow(global::java.lang.Boolean.staticClass, "compareTo", "(Ljava/lang/Object;)I");
			global::java.lang.Boolean._getBoolean14107 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Boolean.staticClass, "getBoolean", "(Ljava/lang/String;)Z");
			global::java.lang.Boolean._valueOf14108 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Boolean.staticClass, "valueOf", "(Z)Ljava/lang/Boolean;");
			global::java.lang.Boolean._valueOf14109 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Boolean.staticClass, "valueOf", "(Ljava/lang/String;)Ljava/lang/Boolean;");
			global::java.lang.Boolean._booleanValue14110 = @__env.GetMethodIDNoThrow(global::java.lang.Boolean.staticClass, "booleanValue", "()Z");
			global::java.lang.Boolean._parseBoolean14111 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Boolean.staticClass, "parseBoolean", "(Ljava/lang/String;)Z");
			global::java.lang.Boolean._Boolean14112 = @__env.GetMethodIDNoThrow(global::java.lang.Boolean.staticClass, "<init>", "(Z)V");
			global::java.lang.Boolean._Boolean14113 = @__env.GetMethodIDNoThrow(global::java.lang.Boolean.staticClass, "<init>", "(Ljava/lang/String;)V");
		}
	}
}
