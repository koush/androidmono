namespace android.os
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class PatternMatcher : java.lang.Object, Parcelable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static PatternMatcher()
		{
			InitJNI();
		}
		protected PatternMatcher(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _toString10071;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.os.PatternMatcher._toString10071)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.os.PatternMatcher.staticClass, global::android.os.PatternMatcher._toString10071)) as java.lang.String;
		}
		public new int Type
		{
			get
			{
				return getType();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getType10072;
		public virtual int getType() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.os.PatternMatcher._getType10072);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.os.PatternMatcher.staticClass, global::android.os.PatternMatcher._getType10072);
		}
		public new global::java.lang.String Path
		{
			get
			{
				return getPath();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getPath10073;
		public virtual global::java.lang.String getPath() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.os.PatternMatcher._getPath10073)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.os.PatternMatcher.staticClass, global::android.os.PatternMatcher._getPath10073)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _match10074;
		public virtual bool match(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.os.PatternMatcher._match10074, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.os.PatternMatcher.staticClass, global::android.os.PatternMatcher._match10074, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeToParcel10075;
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.PatternMatcher._writeToParcel10075, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.PatternMatcher.staticClass, global::android.os.PatternMatcher._writeToParcel10075, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _describeContents10076;
		public virtual int describeContents() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.os.PatternMatcher._describeContents10076);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.os.PatternMatcher.staticClass, global::android.os.PatternMatcher._describeContents10076);
		}
		internal static global::MonoJavaBridge.MethodId _PatternMatcher10077;
		public PatternMatcher(java.lang.String arg0, int arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.os.PatternMatcher.staticClass, global::android.os.PatternMatcher._PatternMatcher10077, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _PatternMatcher10078;
		public PatternMatcher(android.os.Parcel arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.os.PatternMatcher.staticClass, global::android.os.PatternMatcher._PatternMatcher10078, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.FieldId _CREATOR10082;
		public static global::android.os.Parcelable_Creator CREATOR
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.Parcelable_Creator>(@__env.GetStaticObjectField(global::android.os.PatternMatcher.staticClass, _CREATOR10082)) as android.os.Parcelable_Creator;
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.os.PatternMatcher.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/os/PatternMatcher"));
			global::android.os.PatternMatcher._toString10071 = @__env.GetMethodIDNoThrow(global::android.os.PatternMatcher.staticClass, "toString", "()Ljava/lang/String;");
			global::android.os.PatternMatcher._getType10072 = @__env.GetMethodIDNoThrow(global::android.os.PatternMatcher.staticClass, "getType", "()I");
			global::android.os.PatternMatcher._getPath10073 = @__env.GetMethodIDNoThrow(global::android.os.PatternMatcher.staticClass, "getPath", "()Ljava/lang/String;");
			global::android.os.PatternMatcher._match10074 = @__env.GetMethodIDNoThrow(global::android.os.PatternMatcher.staticClass, "match", "(Ljava/lang/String;)Z");
			global::android.os.PatternMatcher._writeToParcel10075 = @__env.GetMethodIDNoThrow(global::android.os.PatternMatcher.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
			global::android.os.PatternMatcher._describeContents10076 = @__env.GetMethodIDNoThrow(global::android.os.PatternMatcher.staticClass, "describeContents", "()I");
			global::android.os.PatternMatcher._PatternMatcher10077 = @__env.GetMethodIDNoThrow(global::android.os.PatternMatcher.staticClass, "<init>", "(Ljava/lang/String;I)V");
			global::android.os.PatternMatcher._PatternMatcher10078 = @__env.GetMethodIDNoThrow(global::android.os.PatternMatcher.staticClass, "<init>", "(Landroid/os/Parcel;)V");
			global::android.os.PatternMatcher._CREATOR10082 = @__env.GetStaticFieldIDNoThrow(global::android.os.PatternMatcher.staticClass, "CREATOR", "Landroid/os/Parcelable$Creator;");
		}
	}
}
