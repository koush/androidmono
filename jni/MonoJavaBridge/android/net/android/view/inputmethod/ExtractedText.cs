namespace android.view.inputmethod 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class ExtractedText : java.lang.Object, android.os.Parcelable
	{ 
		internal static global::java.lang.Class staticClass; 
		static ExtractedText() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.view.inputmethod.ExtractedText), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.view.inputmethod.ExtractedText(@__env); 
			} 
		} 
		protected ExtractedText(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _writeToParcel8434; 
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.inputmethod.ExtractedText)) 
				@__env.CallVoidMethod(this, _writeToParcel8434, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.inputmethod.ExtractedText.staticClass, _writeToParcel8434, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _describeContents8435; 
		public virtual int describeContents() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.inputmethod.ExtractedText)) 
				return @__env.CallIntMethod(this, _describeContents8435); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.view.inputmethod.ExtractedText.staticClass, _describeContents8435); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _ExtractedText8436; 
		public ExtractedText()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.view.inputmethod.ExtractedText.staticClass, _ExtractedText8436, this); 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _text8437; 
		public java.lang.CharSequence text
		{ 
			get 
			{ 
				return default(java.lang.CharSequence); 
			} 
			set 
			{ 
			} 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _startOffset8438; 
		public int startOffset
		{ 
			get 
			{ 
				return default(int); 
			} 
			set 
			{ 
			} 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _partialStartOffset8439; 
		public int partialStartOffset
		{ 
			get 
			{ 
				return default(int); 
			} 
			set 
			{ 
			} 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _partialEndOffset8440; 
		public int partialEndOffset
		{ 
			get 
			{ 
				return default(int); 
			} 
			set 
			{ 
			} 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _selectionStart8441; 
		public int selectionStart
		{ 
			get 
			{ 
				return default(int); 
			} 
			set 
			{ 
			} 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _selectionEnd8442; 
		public int selectionEnd
		{ 
			get 
			{ 
				return default(int); 
			} 
			set 
			{ 
			} 
		} 
		public static int FLAG_SINGLE_LINE
		{ 
			get 
			{ 
				return 1; 
			} 
		} 
		public static int FLAG_SELECTING
		{ 
			get 
			{ 
				return 2; 
			} 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _flags8443; 
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
		internal static global::net.sf.jni4net.jni.FieldId _CREATOR8444; 
		public static android.os.Parcelable_Creator CREATOR
		{ 
			get 
			{ 
				return default(android.os.Parcelable_Creator); 
			} 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.view.inputmethod.ExtractedText.staticClass = @__class; 
			global::android.view.inputmethod.ExtractedText._writeToParcel8434 = @__env.GetMethodID(global::android.view.inputmethod.ExtractedText.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V"); 
			global::android.view.inputmethod.ExtractedText._describeContents8435 = @__env.GetMethodID(global::android.view.inputmethod.ExtractedText.staticClass, "describeContents", "()I"); 
			global::android.view.inputmethod.ExtractedText._ExtractedText8436 = @__env.GetMethodID(global::android.view.inputmethod.ExtractedText.staticClass, "<init>", "()V"); 
		} 
	} 
} 
