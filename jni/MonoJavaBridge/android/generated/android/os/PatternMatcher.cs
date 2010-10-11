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
		internal static global::MonoJavaBridge.MethodId _toString6664;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.os.PatternMatcher._toString6664)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.os.PatternMatcher.staticClass, global::android.os.PatternMatcher._toString6664)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getType6665;
		public virtual int getType() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.os.PatternMatcher._getType6665);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.os.PatternMatcher.staticClass, global::android.os.PatternMatcher._getType6665);
		}
		internal static global::MonoJavaBridge.MethodId _getPath6666;
		public virtual global::java.lang.String getPath() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.os.PatternMatcher._getPath6666)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.os.PatternMatcher.staticClass, global::android.os.PatternMatcher._getPath6666)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _match6667;
		public virtual bool match(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.os.PatternMatcher._match6667, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.os.PatternMatcher.staticClass, global::android.os.PatternMatcher._match6667, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeToParcel6668;
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.PatternMatcher._writeToParcel6668, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.PatternMatcher.staticClass, global::android.os.PatternMatcher._writeToParcel6668, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _describeContents6669;
		public virtual int describeContents() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.os.PatternMatcher._describeContents6669);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.os.PatternMatcher.staticClass, global::android.os.PatternMatcher._describeContents6669);
		}
		internal static global::MonoJavaBridge.MethodId _PatternMatcher6670;
		public PatternMatcher(java.lang.String arg0, int arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.os.PatternMatcher.staticClass, global::android.os.PatternMatcher._PatternMatcher6670, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _PatternMatcher6671;
		public PatternMatcher(android.os.Parcel arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.os.PatternMatcher.staticClass, global::android.os.PatternMatcher._PatternMatcher6671, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.FieldId _CREATOR6672;
		public static global::android.os.Parcelable_Creator CREATOR
		{
			get
			{
				return default(global::android.os.Parcelable_Creator);
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.os.PatternMatcher.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/os/PatternMatcher"));
			global::android.os.PatternMatcher._toString6664 = @__env.GetMethodIDNoThrow(global::android.os.PatternMatcher.staticClass, "toString", "()Ljava/lang/String;");
			global::android.os.PatternMatcher._getType6665 = @__env.GetMethodIDNoThrow(global::android.os.PatternMatcher.staticClass, "getType", "()I");
			global::android.os.PatternMatcher._getPath6666 = @__env.GetMethodIDNoThrow(global::android.os.PatternMatcher.staticClass, "getPath", "()Ljava/lang/String;");
			global::android.os.PatternMatcher._match6667 = @__env.GetMethodIDNoThrow(global::android.os.PatternMatcher.staticClass, "match", "(Ljava/lang/String;)Z");
			global::android.os.PatternMatcher._writeToParcel6668 = @__env.GetMethodIDNoThrow(global::android.os.PatternMatcher.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
			global::android.os.PatternMatcher._describeContents6669 = @__env.GetMethodIDNoThrow(global::android.os.PatternMatcher.staticClass, "describeContents", "()I");
			global::android.os.PatternMatcher._PatternMatcher6670 = @__env.GetMethodIDNoThrow(global::android.os.PatternMatcher.staticClass, "<init>", "(Ljava/lang/String;I)V");
			global::android.os.PatternMatcher._PatternMatcher6671 = @__env.GetMethodIDNoThrow(global::android.os.PatternMatcher.staticClass, "<init>", "(Landroid/os/Parcel;)V");
		}
	}
}
