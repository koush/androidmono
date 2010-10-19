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
		internal static global::MonoJavaBridge.MethodId _writeToParcel10688;
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.inputmethod.ExtractedTextRequest._writeToParcel10688, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.inputmethod.ExtractedTextRequest.staticClass, global::android.view.inputmethod.ExtractedTextRequest._writeToParcel10688, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _describeContents10689;
		public virtual int describeContents() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.inputmethod.ExtractedTextRequest._describeContents10689);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.inputmethod.ExtractedTextRequest.staticClass, global::android.view.inputmethod.ExtractedTextRequest._describeContents10689);
		}
		internal static global::MonoJavaBridge.MethodId _ExtractedTextRequest10690;
		public ExtractedTextRequest()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.inputmethod.ExtractedTextRequest.staticClass, global::android.view.inputmethod.ExtractedTextRequest._ExtractedTextRequest10690);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _token10691;
		public int token
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _flags10692;
		public int flags
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _hintMaxLines10693;
		public int hintMaxLines
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _hintMaxChars10694;
		public int hintMaxChars
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _CREATOR10695;
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
			global::android.view.inputmethod.ExtractedTextRequest.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/inputmethod/ExtractedTextRequest"));
			global::android.view.inputmethod.ExtractedTextRequest._writeToParcel10688 = @__env.GetMethodIDNoThrow(global::android.view.inputmethod.ExtractedTextRequest.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
			global::android.view.inputmethod.ExtractedTextRequest._describeContents10689 = @__env.GetMethodIDNoThrow(global::android.view.inputmethod.ExtractedTextRequest.staticClass, "describeContents", "()I");
			global::android.view.inputmethod.ExtractedTextRequest._ExtractedTextRequest10690 = @__env.GetMethodIDNoThrow(global::android.view.inputmethod.ExtractedTextRequest.staticClass, "<init>", "()V");
		}
	}
}
