namespace android.view.inputmethod 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class ExtractedTextRequest : java.lang.Object, android.os.Parcelable
	{ 
		internal static global::java.lang.Class staticClass; 
		static ExtractedTextRequest() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.view.inputmethod.ExtractedTextRequest), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
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
		internal static global::net.sf.jni4net.jni.MethodId _writeToParcel8445; 
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.inputmethod.ExtractedTextRequest)) 
				@__env.CallVoidMethod(this, _writeToParcel8445, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.inputmethod.ExtractedTextRequest.staticClass, _writeToParcel8445, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _describeContents8446; 
		public virtual int describeContents() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.inputmethod.ExtractedTextRequest)) 
				return @__env.CallIntMethod(this, _describeContents8446); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.view.inputmethod.ExtractedTextRequest.staticClass, _describeContents8446); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _ExtractedTextRequest8447; 
		public ExtractedTextRequest()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.view.inputmethod.ExtractedTextRequest.staticClass, _ExtractedTextRequest8447, this); 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _token8448; 
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
		internal static global::net.sf.jni4net.jni.FieldId _flags8449; 
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
		internal static global::net.sf.jni4net.jni.FieldId _hintMaxLines8450; 
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
		internal static global::net.sf.jni4net.jni.FieldId _hintMaxChars8451; 
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
		internal static global::net.sf.jni4net.jni.FieldId _CREATOR8452; 
		public static android.os.Parcelable_Creator CREATOR
		{ 
			get 
			{ 
				return default(android.os.Parcelable_Creator); 
			} 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.view.inputmethod.ExtractedTextRequest.staticClass = @__class; 
			global::android.view.inputmethod.ExtractedTextRequest._writeToParcel8445 = @__env.GetMethodID(global::android.view.inputmethod.ExtractedTextRequest.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V"); 
			global::android.view.inputmethod.ExtractedTextRequest._describeContents8446 = @__env.GetMethodID(global::android.view.inputmethod.ExtractedTextRequest.staticClass, "describeContents", "()I"); 
			global::android.view.inputmethod.ExtractedTextRequest._ExtractedTextRequest8447 = @__env.GetMethodID(global::android.view.inputmethod.ExtractedTextRequest.staticClass, "<init>", "()V"); 
		} 
	} 
} 
