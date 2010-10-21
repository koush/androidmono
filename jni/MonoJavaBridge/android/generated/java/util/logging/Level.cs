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
		internal static global::MonoJavaBridge.MethodId _equals27859;
		public override bool equals(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.logging.Level._equals27859, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.logging.Level.staticClass, global::java.util.logging.Level._equals27859, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString27860;
		public sealed override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.logging.Level._toString27860)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.logging.Level.staticClass, global::java.util.logging.Level._toString27860)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode27861;
		public override int hashCode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.logging.Level._hashCode27861);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.logging.Level.staticClass, global::java.util.logging.Level._hashCode27861);
		}
		public new global::java.lang.String Name
		{
			get
			{
				return getName();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getName27862;
		public virtual global::java.lang.String getName() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.logging.Level._getName27862)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.logging.Level.staticClass, global::java.util.logging.Level._getName27862)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _intValue27863;
		public virtual int intValue() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.logging.Level._intValue27863);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.logging.Level.staticClass, global::java.util.logging.Level._intValue27863);
		}
		internal static global::MonoJavaBridge.MethodId _parse27864;
		public static global::java.util.logging.Level parse(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.util.logging.Level.staticClass, global::java.util.logging.Level._parse27864, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.logging.Level;
		}
		public new global::java.lang.String ResourceBundleName
		{
			get
			{
				return getResourceBundleName();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getResourceBundleName27865;
		public virtual global::java.lang.String getResourceBundleName() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.logging.Level._getResourceBundleName27865)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.logging.Level.staticClass, global::java.util.logging.Level._getResourceBundleName27865)) as java.lang.String;
		}
		public new global::java.lang.String LocalizedName
		{
			get
			{
				return getLocalizedName();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getLocalizedName27866;
		public virtual global::java.lang.String getLocalizedName() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.logging.Level._getLocalizedName27866)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.logging.Level.staticClass, global::java.util.logging.Level._getLocalizedName27866)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _Level27867;
		protected Level(java.lang.String arg0, int arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.logging.Level.staticClass, global::java.util.logging.Level._Level27867, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Level27868;
		protected Level(java.lang.String arg0, int arg1, java.lang.String arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.logging.Level.staticClass, global::java.util.logging.Level._Level27868, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _OFF27869;
		public static global::java.util.logging.Level OFF
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::java.util.logging.Level.staticClass, _OFF27869)) as java.util.logging.Level;
			}
		}
		internal static global::MonoJavaBridge.FieldId _SEVERE27870;
		public static global::java.util.logging.Level SEVERE
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::java.util.logging.Level.staticClass, _SEVERE27870)) as java.util.logging.Level;
			}
		}
		internal static global::MonoJavaBridge.FieldId _WARNING27871;
		public static global::java.util.logging.Level WARNING
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::java.util.logging.Level.staticClass, _WARNING27871)) as java.util.logging.Level;
			}
		}
		internal static global::MonoJavaBridge.FieldId _INFO27872;
		public static global::java.util.logging.Level INFO
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::java.util.logging.Level.staticClass, _INFO27872)) as java.util.logging.Level;
			}
		}
		internal static global::MonoJavaBridge.FieldId _CONFIG27873;
		public static global::java.util.logging.Level CONFIG
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::java.util.logging.Level.staticClass, _CONFIG27873)) as java.util.logging.Level;
			}
		}
		internal static global::MonoJavaBridge.FieldId _FINE27874;
		public static global::java.util.logging.Level FINE
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::java.util.logging.Level.staticClass, _FINE27874)) as java.util.logging.Level;
			}
		}
		internal static global::MonoJavaBridge.FieldId _FINER27875;
		public static global::java.util.logging.Level FINER
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::java.util.logging.Level.staticClass, _FINER27875)) as java.util.logging.Level;
			}
		}
		internal static global::MonoJavaBridge.FieldId _FINEST27876;
		public static global::java.util.logging.Level FINEST
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::java.util.logging.Level.staticClass, _FINEST27876)) as java.util.logging.Level;
			}
		}
		internal static global::MonoJavaBridge.FieldId _ALL27877;
		public static global::java.util.logging.Level ALL
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::java.util.logging.Level.staticClass, _ALL27877)) as java.util.logging.Level;
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.logging.Level.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/logging/Level"));
			global::java.util.logging.Level._equals27859 = @__env.GetMethodIDNoThrow(global::java.util.logging.Level.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.util.logging.Level._toString27860 = @__env.GetMethodIDNoThrow(global::java.util.logging.Level.staticClass, "toString", "()Ljava/lang/String;");
			global::java.util.logging.Level._hashCode27861 = @__env.GetMethodIDNoThrow(global::java.util.logging.Level.staticClass, "hashCode", "()I");
			global::java.util.logging.Level._getName27862 = @__env.GetMethodIDNoThrow(global::java.util.logging.Level.staticClass, "getName", "()Ljava/lang/String;");
			global::java.util.logging.Level._intValue27863 = @__env.GetMethodIDNoThrow(global::java.util.logging.Level.staticClass, "intValue", "()I");
			global::java.util.logging.Level._parse27864 = @__env.GetStaticMethodIDNoThrow(global::java.util.logging.Level.staticClass, "parse", "(Ljava/lang/String;)Ljava/util/logging/Level;");
			global::java.util.logging.Level._getResourceBundleName27865 = @__env.GetMethodIDNoThrow(global::java.util.logging.Level.staticClass, "getResourceBundleName", "()Ljava/lang/String;");
			global::java.util.logging.Level._getLocalizedName27866 = @__env.GetMethodIDNoThrow(global::java.util.logging.Level.staticClass, "getLocalizedName", "()Ljava/lang/String;");
			global::java.util.logging.Level._Level27867 = @__env.GetMethodIDNoThrow(global::java.util.logging.Level.staticClass, "<init>", "(Ljava/lang/String;I)V");
			global::java.util.logging.Level._Level27868 = @__env.GetMethodIDNoThrow(global::java.util.logging.Level.staticClass, "<init>", "(Ljava/lang/String;ILjava/lang/String;)V");
			global::java.util.logging.Level._OFF27869 = @__env.GetStaticFieldIDNoThrow(global::java.util.logging.Level.staticClass, "OFF", "Ljava/util/logging/Level;");
			global::java.util.logging.Level._SEVERE27870 = @__env.GetStaticFieldIDNoThrow(global::java.util.logging.Level.staticClass, "SEVERE", "Ljava/util/logging/Level;");
			global::java.util.logging.Level._WARNING27871 = @__env.GetStaticFieldIDNoThrow(global::java.util.logging.Level.staticClass, "WARNING", "Ljava/util/logging/Level;");
			global::java.util.logging.Level._INFO27872 = @__env.GetStaticFieldIDNoThrow(global::java.util.logging.Level.staticClass, "INFO", "Ljava/util/logging/Level;");
			global::java.util.logging.Level._CONFIG27873 = @__env.GetStaticFieldIDNoThrow(global::java.util.logging.Level.staticClass, "CONFIG", "Ljava/util/logging/Level;");
			global::java.util.logging.Level._FINE27874 = @__env.GetStaticFieldIDNoThrow(global::java.util.logging.Level.staticClass, "FINE", "Ljava/util/logging/Level;");
			global::java.util.logging.Level._FINER27875 = @__env.GetStaticFieldIDNoThrow(global::java.util.logging.Level.staticClass, "FINER", "Ljava/util/logging/Level;");
			global::java.util.logging.Level._FINEST27876 = @__env.GetStaticFieldIDNoThrow(global::java.util.logging.Level.staticClass, "FINEST", "Ljava/util/logging/Level;");
			global::java.util.logging.Level._ALL27877 = @__env.GetStaticFieldIDNoThrow(global::java.util.logging.Level.staticClass, "ALL", "Ljava/util/logging/Level;");
		}
	}
}
