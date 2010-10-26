namespace android.view.inputmethod
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ExtractedTextRequest : java.lang.Object, android.os.Parcelable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static ExtractedTextRequest()
		{
			InitJNI();
		}
		protected ExtractedTextRequest(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _writeToParcel15854;
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.inputmethod.ExtractedTextRequest._writeToParcel15854, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.inputmethod.ExtractedTextRequest.staticClass, global::android.view.inputmethod.ExtractedTextRequest._writeToParcel15854, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _describeContents15855;
		public virtual int describeContents() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.inputmethod.ExtractedTextRequest._describeContents15855);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.inputmethod.ExtractedTextRequest.staticClass, global::android.view.inputmethod.ExtractedTextRequest._describeContents15855);
		}
		internal static global::MonoJavaBridge.MethodId _ExtractedTextRequest15856;
		public ExtractedTextRequest()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.inputmethod.ExtractedTextRequest.staticClass, global::android.view.inputmethod.ExtractedTextRequest._ExtractedTextRequest15856);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _token15857;
		public int token
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _token15857);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _flags15858;
		public int flags
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _flags15858);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _hintMaxLines15859;
		public int hintMaxLines
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _hintMaxLines15859);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _hintMaxChars15860;
		public int hintMaxChars
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _hintMaxChars15860);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _CREATOR15861;
		public static global::android.os.Parcelable_Creator CREATOR
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.Parcelable_Creator>(@__env.GetStaticObjectField(global::android.view.inputmethod.ExtractedTextRequest.staticClass, _CREATOR15861)) as android.os.Parcelable_Creator;
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.view.inputmethod.ExtractedTextRequest.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/inputmethod/ExtractedTextRequest"));
			global::android.view.inputmethod.ExtractedTextRequest._writeToParcel15854 = @__env.GetMethodIDNoThrow(global::android.view.inputmethod.ExtractedTextRequest.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
			global::android.view.inputmethod.ExtractedTextRequest._describeContents15855 = @__env.GetMethodIDNoThrow(global::android.view.inputmethod.ExtractedTextRequest.staticClass, "describeContents", "()I");
			global::android.view.inputmethod.ExtractedTextRequest._ExtractedTextRequest15856 = @__env.GetMethodIDNoThrow(global::android.view.inputmethod.ExtractedTextRequest.staticClass, "<init>", "()V");
			global::android.view.inputmethod.ExtractedTextRequest._token15857 = @__env.GetFieldIDNoThrow(global::android.view.inputmethod.ExtractedTextRequest.staticClass, "token", "I");
			global::android.view.inputmethod.ExtractedTextRequest._flags15858 = @__env.GetFieldIDNoThrow(global::android.view.inputmethod.ExtractedTextRequest.staticClass, "flags", "I");
			global::android.view.inputmethod.ExtractedTextRequest._hintMaxLines15859 = @__env.GetFieldIDNoThrow(global::android.view.inputmethod.ExtractedTextRequest.staticClass, "hintMaxLines", "I");
			global::android.view.inputmethod.ExtractedTextRequest._hintMaxChars15860 = @__env.GetFieldIDNoThrow(global::android.view.inputmethod.ExtractedTextRequest.staticClass, "hintMaxChars", "I");
			global::android.view.inputmethod.ExtractedTextRequest._CREATOR15861 = @__env.GetStaticFieldIDNoThrow(global::android.view.inputmethod.ExtractedTextRequest.staticClass, "CREATOR", "Landroid/os/Parcelable$Creator;");
		}
	}
}
