namespace android.os
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class PatternMatcher : java.lang.Object, Parcelable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected PatternMatcher(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _toString10117;
		public override global::java.lang.String toString()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.os.PatternMatcher._toString10117.native == global::System.IntPtr.Zero)
				global::android.os.PatternMatcher._toString10117 = @__env.GetMethodIDNoThrow(global::android.os.PatternMatcher.staticClass, "toString", "()Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.os.PatternMatcher.staticClass, global::android.os.PatternMatcher._toString10117) as java.lang.String;
		}
		public new int Type
		{
			get
			{
				return getType();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getType10118;
		public virtual int getType()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.os.PatternMatcher._getType10118.native == global::System.IntPtr.Zero)
				global::android.os.PatternMatcher._getType10118 = @__env.GetMethodIDNoThrow(global::android.os.PatternMatcher.staticClass, "getType", "()I");
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.os.PatternMatcher.staticClass, global::android.os.PatternMatcher._getType10118);
		}
		public new global::java.lang.String Path
		{
			get
			{
				return getPath();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getPath10119;
		public virtual global::java.lang.String getPath()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.os.PatternMatcher._getPath10119.native == global::System.IntPtr.Zero)
				global::android.os.PatternMatcher._getPath10119 = @__env.GetMethodIDNoThrow(global::android.os.PatternMatcher.staticClass, "getPath", "()Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.os.PatternMatcher.staticClass, global::android.os.PatternMatcher._getPath10119) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _match10120;
		public virtual bool match(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.os.PatternMatcher._match10120.native == global::System.IntPtr.Zero)
				global::android.os.PatternMatcher._match10120 = @__env.GetMethodIDNoThrow(global::android.os.PatternMatcher.staticClass, "match", "(Ljava/lang/String;)Z");
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.os.PatternMatcher.staticClass, global::android.os.PatternMatcher._match10120, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeToParcel10121;
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.os.PatternMatcher._writeToParcel10121.native == global::System.IntPtr.Zero)
				global::android.os.PatternMatcher._writeToParcel10121 = @__env.GetMethodIDNoThrow(global::android.os.PatternMatcher.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.os.PatternMatcher.staticClass, global::android.os.PatternMatcher._writeToParcel10121, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _describeContents10122;
		public virtual int describeContents()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.os.PatternMatcher._describeContents10122.native == global::System.IntPtr.Zero)
				global::android.os.PatternMatcher._describeContents10122 = @__env.GetMethodIDNoThrow(global::android.os.PatternMatcher.staticClass, "describeContents", "()I");
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.os.PatternMatcher.staticClass, global::android.os.PatternMatcher._describeContents10122);
		}
		internal static global::MonoJavaBridge.MethodId _PatternMatcher10123;
		public PatternMatcher(java.lang.String arg0, int arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.os.PatternMatcher._PatternMatcher10123.native == global::System.IntPtr.Zero)
				global::android.os.PatternMatcher._PatternMatcher10123 = @__env.GetMethodIDNoThrow(global::android.os.PatternMatcher.staticClass, "<init>", "(Ljava/lang/String;I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.os.PatternMatcher.staticClass, global::android.os.PatternMatcher._PatternMatcher10123, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _PatternMatcher10124;
		public PatternMatcher(android.os.Parcel arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.os.PatternMatcher._PatternMatcher10124.native == global::System.IntPtr.Zero)
				global::android.os.PatternMatcher._PatternMatcher10124 = @__env.GetMethodIDNoThrow(global::android.os.PatternMatcher.staticClass, "<init>", "(Landroid/os/Parcel;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.os.PatternMatcher.staticClass, global::android.os.PatternMatcher._PatternMatcher10124, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		public static int PATTERN_LITERAL
		{
			get
			{
				return 0;
			}
		}
		public static int PATTERN_PREFIX
		{
			get
			{
				return 1;
			}
		}
		public static int PATTERN_SIMPLE_GLOB
		{
			get
			{
				return 2;
			}
		}
		internal static global::MonoJavaBridge.FieldId _CREATOR10128;
		public static global::android.os.Parcelable_Creator CREATOR
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.Parcelable_Creator>(@__env.GetStaticObjectField(global::android.os.PatternMatcher.staticClass, _CREATOR10128)) as android.os.Parcelable_Creator;
			}
		}
		static PatternMatcher()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.os.PatternMatcher.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/os/PatternMatcher"));
			global::android.os.PatternMatcher._CREATOR10128 = @__env.GetStaticFieldIDNoThrow(global::android.os.PatternMatcher.staticClass, "CREATOR", "Landroid/os/Parcelable$Creator;");
		}
		internal static void InitJNI()
		{
		}
	}
}
