namespace android.os
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class PatternMatcher : java.lang.Object, Parcelable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected PatternMatcher(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.os.PatternMatcher.staticClass, "toString", "()Ljava/lang/String;", ref global::android.os.PatternMatcher._m0) as java.lang.String;
		}
		public new int Type
		{
			get
			{
				return getType();
			}
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual int getType()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.os.PatternMatcher.staticClass, "getType", "()I", ref global::android.os.PatternMatcher._m1);
		}
		public new global::java.lang.String Path
		{
			get
			{
				return getPath();
			}
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual global::java.lang.String getPath()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.os.PatternMatcher.staticClass, "getPath", "()Ljava/lang/String;", ref global::android.os.PatternMatcher._m2) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual bool match(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.os.PatternMatcher.staticClass, "match", "(Ljava/lang/String;)Z", ref global::android.os.PatternMatcher._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.os.PatternMatcher.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V", ref global::android.os.PatternMatcher._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual int describeContents()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.os.PatternMatcher.staticClass, "describeContents", "()I", ref global::android.os.PatternMatcher._m5);
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public PatternMatcher(java.lang.String arg0, int arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.os.PatternMatcher._m6.native == global::System.IntPtr.Zero)
				global::android.os.PatternMatcher._m6 = @__env.GetMethodIDNoThrow(global::android.os.PatternMatcher.staticClass, "<init>", "(Ljava/lang/String;I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.os.PatternMatcher.staticClass, global::android.os.PatternMatcher._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public PatternMatcher(android.os.Parcel arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.os.PatternMatcher._m7.native == global::System.IntPtr.Zero)
				global::android.os.PatternMatcher._m7 = @__env.GetMethodIDNoThrow(global::android.os.PatternMatcher.staticClass, "<init>", "(Landroid/os/Parcel;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.os.PatternMatcher.staticClass, global::android.os.PatternMatcher._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.FieldId _CREATOR4026;
		public static global::android.os.Parcelable_Creator CREATOR
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.Parcelable_Creator>(@__env.GetStaticObjectField(global::android.os.PatternMatcher.staticClass, _CREATOR4026)) as android.os.Parcelable_Creator;
			}
		}
		static PatternMatcher()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.os.PatternMatcher.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/os/PatternMatcher"));
			global::android.os.PatternMatcher._CREATOR4026 = @__env.GetStaticFieldIDNoThrow(global::android.os.PatternMatcher.staticClass, "CREATOR", "Landroid/os/Parcelable$Creator;");
		}
	}
}
