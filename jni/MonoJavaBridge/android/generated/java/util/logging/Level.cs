namespace java.util.logging
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class Level : java.lang.Object, java.io.Serializable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Level()
		{
			InitJNI();
		}
		protected Level(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _equals21998;
		public override bool equals(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.logging.Level._equals21998, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.logging.Level.staticClass, global::java.util.logging.Level._equals21998, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString21999;
		public sealed override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.logging.Level._toString21999)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.logging.Level.staticClass, global::java.util.logging.Level._toString21999)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode22000;
		public override int hashCode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.logging.Level._hashCode22000);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.logging.Level.staticClass, global::java.util.logging.Level._hashCode22000);
		}
		public new global::java.lang.String Name
		{
			get
			{
				return getName();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getName22001;
		public virtual global::java.lang.String getName() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.logging.Level._getName22001)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.logging.Level.staticClass, global::java.util.logging.Level._getName22001)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _intValue22002;
		public virtual int intValue() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.logging.Level._intValue22002);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.logging.Level.staticClass, global::java.util.logging.Level._intValue22002);
		}
		internal static global::MonoJavaBridge.MethodId _parse22003;
		public static global::java.util.logging.Level parse(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.util.logging.Level.staticClass, global::java.util.logging.Level._parse22003, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.logging.Level;
		}
		public new global::java.lang.String ResourceBundleName
		{
			get
			{
				return getResourceBundleName();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getResourceBundleName22004;
		public virtual global::java.lang.String getResourceBundleName() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.logging.Level._getResourceBundleName22004)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.logging.Level.staticClass, global::java.util.logging.Level._getResourceBundleName22004)) as java.lang.String;
		}
		public new global::java.lang.String LocalizedName
		{
			get
			{
				return getLocalizedName();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getLocalizedName22005;
		public virtual global::java.lang.String getLocalizedName() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.logging.Level._getLocalizedName22005)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.logging.Level.staticClass, global::java.util.logging.Level._getLocalizedName22005)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _Level22006;
		protected Level(java.lang.String arg0, int arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.logging.Level.staticClass, global::java.util.logging.Level._Level22006, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Level22007;
		protected Level(java.lang.String arg0, int arg1, java.lang.String arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.logging.Level.staticClass, global::java.util.logging.Level._Level22007, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _OFF22008;
		public static global::java.util.logging.Level OFF
		{
			get
			{
				return default(global::java.util.logging.Level);
			}
		}
		internal static global::MonoJavaBridge.FieldId _SEVERE22009;
		public static global::java.util.logging.Level SEVERE
		{
			get
			{
				return default(global::java.util.logging.Level);
			}
		}
		internal static global::MonoJavaBridge.FieldId _WARNING22010;
		public static global::java.util.logging.Level WARNING
		{
			get
			{
				return default(global::java.util.logging.Level);
			}
		}
		internal static global::MonoJavaBridge.FieldId _INFO22011;
		public static global::java.util.logging.Level INFO
		{
			get
			{
				return default(global::java.util.logging.Level);
			}
		}
		internal static global::MonoJavaBridge.FieldId _CONFIG22012;
		public static global::java.util.logging.Level CONFIG
		{
			get
			{
				return default(global::java.util.logging.Level);
			}
		}
		internal static global::MonoJavaBridge.FieldId _FINE22013;
		public static global::java.util.logging.Level FINE
		{
			get
			{
				return default(global::java.util.logging.Level);
			}
		}
		internal static global::MonoJavaBridge.FieldId _FINER22014;
		public static global::java.util.logging.Level FINER
		{
			get
			{
				return default(global::java.util.logging.Level);
			}
		}
		internal static global::MonoJavaBridge.FieldId _FINEST22015;
		public static global::java.util.logging.Level FINEST
		{
			get
			{
				return default(global::java.util.logging.Level);
			}
		}
		internal static global::MonoJavaBridge.FieldId _ALL22016;
		public static global::java.util.logging.Level ALL
		{
			get
			{
				return default(global::java.util.logging.Level);
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.logging.Level.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/logging/Level"));
			global::java.util.logging.Level._equals21998 = @__env.GetMethodIDNoThrow(global::java.util.logging.Level.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.util.logging.Level._toString21999 = @__env.GetMethodIDNoThrow(global::java.util.logging.Level.staticClass, "toString", "()Ljava/lang/String;");
			global::java.util.logging.Level._hashCode22000 = @__env.GetMethodIDNoThrow(global::java.util.logging.Level.staticClass, "hashCode", "()I");
			global::java.util.logging.Level._getName22001 = @__env.GetMethodIDNoThrow(global::java.util.logging.Level.staticClass, "getName", "()Ljava/lang/String;");
			global::java.util.logging.Level._intValue22002 = @__env.GetMethodIDNoThrow(global::java.util.logging.Level.staticClass, "intValue", "()I");
			global::java.util.logging.Level._parse22003 = @__env.GetStaticMethodIDNoThrow(global::java.util.logging.Level.staticClass, "parse", "(Ljava/lang/String;)Ljava/util/logging/Level;");
			global::java.util.logging.Level._getResourceBundleName22004 = @__env.GetMethodIDNoThrow(global::java.util.logging.Level.staticClass, "getResourceBundleName", "()Ljava/lang/String;");
			global::java.util.logging.Level._getLocalizedName22005 = @__env.GetMethodIDNoThrow(global::java.util.logging.Level.staticClass, "getLocalizedName", "()Ljava/lang/String;");
			global::java.util.logging.Level._Level22006 = @__env.GetMethodIDNoThrow(global::java.util.logging.Level.staticClass, "<init>", "(Ljava/lang/String;I)V");
			global::java.util.logging.Level._Level22007 = @__env.GetMethodIDNoThrow(global::java.util.logging.Level.staticClass, "<init>", "(Ljava/lang/String;ILjava/lang/String;)V");
		}
	}
}
