namespace android.view.inputmethod
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class ExtractedTextRequest : java.lang.Object, android.os.Parcelable
	{
		internal static global::java.lang.Class staticClass;
		static ExtractedTextRequest()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.view.inputmethod.ExtractedTextRequest), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.view.inputmethod.ExtractedTextRequest(@__env);
			}
		}
		protected ExtractedTextRequest(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _writeToParcel9088;
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.inputmethod.ExtractedTextRequest._writeToParcel9088, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.inputmethod.ExtractedTextRequest.staticClass, global::android.view.inputmethod.ExtractedTextRequest._writeToParcel9088, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _describeContents9089;
		public virtual int describeContents() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.view.inputmethod.ExtractedTextRequest._describeContents9089);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.view.inputmethod.ExtractedTextRequest.staticClass, global::android.view.inputmethod.ExtractedTextRequest._describeContents9089);
		}
		internal static global::net.sf.jni4net.jni.MethodId _ExtractedTextRequest9090;
		public ExtractedTextRequest()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.view.inputmethod.ExtractedTextRequest.staticClass, global::android.view.inputmethod.ExtractedTextRequest._ExtractedTextRequest9090, this);
		}
		internal static global::net.sf.jni4net.jni.FieldId _token9091;
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
		internal static global::net.sf.jni4net.jni.FieldId _flags9092;
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
		internal static global::net.sf.jni4net.jni.FieldId _hintMaxLines9093;
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
		internal static global::net.sf.jni4net.jni.FieldId _hintMaxChars9094;
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
		internal static global::net.sf.jni4net.jni.FieldId _CREATOR9095;
		public static global::android.os.Parcelable_Creator CREATOR
		{
			get
			{
				return default(global::android.os.Parcelable_Creator);
			}
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.view.inputmethod.ExtractedTextRequest.staticClass = @__class;
			global::android.view.inputmethod.ExtractedTextRequest._writeToParcel9088 = @__env.GetMethodID(global::android.view.inputmethod.ExtractedTextRequest.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
			global::android.view.inputmethod.ExtractedTextRequest._describeContents9089 = @__env.GetMethodID(global::android.view.inputmethod.ExtractedTextRequest.staticClass, "describeContents", "()I");
			global::android.view.inputmethod.ExtractedTextRequest._ExtractedTextRequest9090 = @__env.GetMethodID(global::android.view.inputmethod.ExtractedTextRequest.staticClass, "<init>", "()V");
		}
	}
}
