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
		internal static global::MonoJavaBridge.MethodId _equals19607;
		public sealed override bool equals(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.lang.Boolean._equals19607, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.lang.Boolean.staticClass, global::java.lang.Boolean._equals19607, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString19608;
		public sealed override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.Boolean._toString19608)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.Boolean.staticClass, global::java.lang.Boolean._toString19608)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _toString19609;
		public static global::java.lang.String toString(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.lang.Boolean.staticClass, global::java.lang.Boolean._toString19609, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode19610;
		public sealed override int hashCode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.lang.Boolean._hashCode19610);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.lang.Boolean.staticClass, global::java.lang.Boolean._hashCode19610);
		}
		internal static global::MonoJavaBridge.MethodId _compareTo19611;
		public int compareTo(java.lang.Boolean arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.lang.Boolean._compareTo19611, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.lang.Boolean.staticClass, global::java.lang.Boolean._compareTo19611, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _compareTo19612;
		public int compareTo(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.lang.Boolean._compareTo19612, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.lang.Boolean.staticClass, global::java.lang.Boolean._compareTo19612, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getBoolean19613;
		public static bool getBoolean(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(java.lang.Boolean.staticClass, global::java.lang.Boolean._getBoolean19613, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _valueOf19614;
		public static global::java.lang.Boolean valueOf(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.lang.Boolean.staticClass, global::java.lang.Boolean._valueOf19614, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Boolean;
		}
		internal static global::MonoJavaBridge.MethodId _valueOf19615;
		public static global::java.lang.Boolean valueOf(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.lang.Boolean.staticClass, global::java.lang.Boolean._valueOf19615, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Boolean;
		}
		internal static global::MonoJavaBridge.MethodId _booleanValue19616;
		public bool booleanValue() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.lang.Boolean._booleanValue19616);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.lang.Boolean.staticClass, global::java.lang.Boolean._booleanValue19616);
		}
		internal static global::MonoJavaBridge.MethodId _parseBoolean19617;
		public static bool parseBoolean(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(java.lang.Boolean.staticClass, global::java.lang.Boolean._parseBoolean19617, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _Boolean19618;
		public Boolean(bool arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.Boolean.staticClass, global::java.lang.Boolean._Boolean19618, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Boolean19619;
		public Boolean(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.Boolean.staticClass, global::java.lang.Boolean._Boolean19619, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _TRUE19620;
		public static global::java.lang.Boolean TRUE
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::java.lang.Boolean.staticClass, _TRUE19620)) as java.lang.Boolean;
			}
		}
		internal static global::MonoJavaBridge.FieldId _FALSE19621;
		public static global::java.lang.Boolean FALSE
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::java.lang.Boolean.staticClass, _FALSE19621)) as java.lang.Boolean;
			}
		}
		internal static global::MonoJavaBridge.FieldId _TYPE19622;
		public static global::java.lang.Class TYPE
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::java.lang.Boolean.staticClass, _TYPE19622)) as java.lang.Class;
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.Boolean.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/Boolean"));
			global::java.lang.Boolean._equals19607 = @__env.GetMethodIDNoThrow(global::java.lang.Boolean.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.lang.Boolean._toString19608 = @__env.GetMethodIDNoThrow(global::java.lang.Boolean.staticClass, "toString", "()Ljava/lang/String;");
			global::java.lang.Boolean._toString19609 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Boolean.staticClass, "toString", "(Z)Ljava/lang/String;");
			global::java.lang.Boolean._hashCode19610 = @__env.GetMethodIDNoThrow(global::java.lang.Boolean.staticClass, "hashCode", "()I");
			global::java.lang.Boolean._compareTo19611 = @__env.GetMethodIDNoThrow(global::java.lang.Boolean.staticClass, "compareTo", "(Ljava/lang/Boolean;)I");
			global::java.lang.Boolean._compareTo19612 = @__env.GetMethodIDNoThrow(global::java.lang.Boolean.staticClass, "compareTo", "(Ljava/lang/Object;)I");
			global::java.lang.Boolean._getBoolean19613 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Boolean.staticClass, "getBoolean", "(Ljava/lang/String;)Z");
			global::java.lang.Boolean._valueOf19614 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Boolean.staticClass, "valueOf", "(Z)Ljava/lang/Boolean;");
			global::java.lang.Boolean._valueOf19615 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Boolean.staticClass, "valueOf", "(Ljava/lang/String;)Ljava/lang/Boolean;");
			global::java.lang.Boolean._booleanValue19616 = @__env.GetMethodIDNoThrow(global::java.lang.Boolean.staticClass, "booleanValue", "()Z");
			global::java.lang.Boolean._parseBoolean19617 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Boolean.staticClass, "parseBoolean", "(Ljava/lang/String;)Z");
			global::java.lang.Boolean._Boolean19618 = @__env.GetMethodIDNoThrow(global::java.lang.Boolean.staticClass, "<init>", "(Z)V");
			global::java.lang.Boolean._Boolean19619 = @__env.GetMethodIDNoThrow(global::java.lang.Boolean.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::java.lang.Boolean._TRUE19620 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Boolean.staticClass, "TRUE", "Ljava/lang/Boolean;");
			global::java.lang.Boolean._FALSE19621 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Boolean.staticClass, "FALSE", "Ljava/lang/Boolean;");
			global::java.lang.Boolean._TYPE19622 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Boolean.staticClass, "TYPE", "Ljava/lang/Class;");
		}
	}
}
