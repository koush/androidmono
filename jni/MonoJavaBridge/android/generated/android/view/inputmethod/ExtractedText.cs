namespace android.view.inputmethod
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class ExtractedText : java.lang.Object, android.os.Parcelable
	{
		internal static global::java.lang.Class staticClass;
		static ExtractedText()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.view.inputmethod.ExtractedText), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
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
		internal static global::net.sf.jni4net.jni.MethodId _writeToParcel9784;
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.inputmethod.ExtractedText._writeToParcel9784, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.inputmethod.ExtractedText.staticClass, global::android.view.inputmethod.ExtractedText._writeToParcel9784, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _describeContents9785;
		public virtual int describeContents() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.view.inputmethod.ExtractedText._describeContents9785);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.view.inputmethod.ExtractedText.staticClass, global::android.view.inputmethod.ExtractedText._describeContents9785);
		}
		internal static global::net.sf.jni4net.jni.MethodId _ExtractedText9786;
		public ExtractedText()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.view.inputmethod.ExtractedText.staticClass, global::android.view.inputmethod.ExtractedText._ExtractedText9786, this);
		}
		internal static global::net.sf.jni4net.jni.FieldId _text9787;
		public global::java.lang.CharSequence text
		{
			get
			{
				return default(global::java.lang.CharSequence);
			}
			set
			{
			}
		}
		internal static global::net.sf.jni4net.jni.FieldId _startOffset9788;
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
		internal static global::net.sf.jni4net.jni.FieldId _partialStartOffset9789;
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
		internal static global::net.sf.jni4net.jni.FieldId _partialEndOffset9790;
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
		internal static global::net.sf.jni4net.jni.FieldId _selectionStart9791;
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
		internal static global::net.sf.jni4net.jni.FieldId _selectionEnd9792;
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
		internal static global::net.sf.jni4net.jni.FieldId _flags9793;
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
		internal static global::net.sf.jni4net.jni.FieldId _CREATOR9794;
		public static global::android.os.Parcelable_Creator CREATOR
		{
			get
			{
				return default(global::android.os.Parcelable_Creator);
			}
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.view.inputmethod.ExtractedText.staticClass = @__class;
			global::android.view.inputmethod.ExtractedText._writeToParcel9784 = @__env.GetMethodID(global::android.view.inputmethod.ExtractedText.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
			global::android.view.inputmethod.ExtractedText._describeContents9785 = @__env.GetMethodID(global::android.view.inputmethod.ExtractedText.staticClass, "describeContents", "()I");
			global::android.view.inputmethod.ExtractedText._ExtractedText9786 = @__env.GetMethodID(global::android.view.inputmethod.ExtractedText.staticClass, "<init>", "()V");
		}
	}
}
