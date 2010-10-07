namespace android.view.inputmethod
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class EditorInfo : java.lang.Object, android.text.InputType, android.os.Parcelable
	{
		internal static global::java.lang.Class staticClass;
		static EditorInfo()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.view.inputmethod.EditorInfo), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.view.inputmethod.EditorInfo(@__env);
			}
		}
		protected EditorInfo(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _dump9765;
		public virtual void dump(android.util.Printer arg0, java.lang.String arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.inputmethod.EditorInfo._dump9765, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.inputmethod.EditorInfo.staticClass, global::android.view.inputmethod.EditorInfo._dump9765, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _writeToParcel9766;
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.inputmethod.EditorInfo._writeToParcel9766, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.inputmethod.EditorInfo.staticClass, global::android.view.inputmethod.EditorInfo._writeToParcel9766, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _describeContents9767;
		public virtual int describeContents() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.view.inputmethod.EditorInfo._describeContents9767);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.view.inputmethod.EditorInfo.staticClass, global::android.view.inputmethod.EditorInfo._describeContents9767);
		}
		internal static global::net.sf.jni4net.jni.MethodId _EditorInfo9768;
		public EditorInfo()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.view.inputmethod.EditorInfo.staticClass, global::android.view.inputmethod.EditorInfo._EditorInfo9768, this);
		}
		internal static global::net.sf.jni4net.jni.FieldId _inputType9769;
		public int inputType
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}
		public static int IME_MASK_ACTION
		{
			get
			{
				return 255;
			}
		}
		public static int IME_ACTION_UNSPECIFIED
		{
			get
			{
				return 0;
			}
		}
		public static int IME_ACTION_NONE
		{
			get
			{
				return 1;
			}
		}
		public static int IME_ACTION_GO
		{
			get
			{
				return 2;
			}
		}
		public static int IME_ACTION_SEARCH
		{
			get
			{
				return 3;
			}
		}
		public static int IME_ACTION_SEND
		{
			get
			{
				return 4;
			}
		}
		public static int IME_ACTION_NEXT
		{
			get
			{
				return 5;
			}
		}
		public static int IME_ACTION_DONE
		{
			get
			{
				return 6;
			}
		}
		public static int IME_FLAG_NO_EXTRACT_UI
		{
			get
			{
				return 268435456;
			}
		}
		public static int IME_FLAG_NO_ACCESSORY_ACTION
		{
			get
			{
				return 536870912;
			}
		}
		public static int IME_FLAG_NO_ENTER_ACTION
		{
			get
			{
				return 1073741824;
			}
		}
		public static int IME_NULL
		{
			get
			{
				return 0;
			}
		}
		internal static global::net.sf.jni4net.jni.FieldId _imeOptions9770;
		public int imeOptions
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}
		internal static global::net.sf.jni4net.jni.FieldId _privateImeOptions9771;
		public global::java.lang.String privateImeOptions
		{
			get
			{
				return default(global::java.lang.String);
			}
			set
			{
			}
		}
		internal static global::net.sf.jni4net.jni.FieldId _actionLabel9772;
		public global::java.lang.CharSequence actionLabel
		{
			get
			{
				return default(global::java.lang.CharSequence);
			}
			set
			{
			}
		}
		internal static global::net.sf.jni4net.jni.FieldId _actionId9773;
		public int actionId
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}
		internal static global::net.sf.jni4net.jni.FieldId _initialSelStart9774;
		public int initialSelStart
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}
		internal static global::net.sf.jni4net.jni.FieldId _initialSelEnd9775;
		public int initialSelEnd
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}
		internal static global::net.sf.jni4net.jni.FieldId _initialCapsMode9776;
		public int initialCapsMode
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}
		internal static global::net.sf.jni4net.jni.FieldId _hintText9777;
		public global::java.lang.CharSequence hintText
		{
			get
			{
				return default(global::java.lang.CharSequence);
			}
			set
			{
			}
		}
		internal static global::net.sf.jni4net.jni.FieldId _label9778;
		public global::java.lang.CharSequence label
		{
			get
			{
				return default(global::java.lang.CharSequence);
			}
			set
			{
			}
		}
		internal static global::net.sf.jni4net.jni.FieldId _packageName9779;
		public global::java.lang.String packageName
		{
			get
			{
				return default(global::java.lang.String);
			}
			set
			{
			}
		}
		internal static global::net.sf.jni4net.jni.FieldId _fieldId9780;
		public int fieldId
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}
		internal static global::net.sf.jni4net.jni.FieldId _fieldName9781;
		public global::java.lang.String fieldName
		{
			get
			{
				return default(global::java.lang.String);
			}
			set
			{
			}
		}
		internal static global::net.sf.jni4net.jni.FieldId _extras9782;
		public global::android.os.Bundle extras
		{
			get
			{
				return default(global::android.os.Bundle);
			}
			set
			{
			}
		}
		internal static global::net.sf.jni4net.jni.FieldId _CREATOR9783;
		public static global::android.os.Parcelable_Creator CREATOR
		{
			get
			{
				return default(global::android.os.Parcelable_Creator);
			}
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.view.inputmethod.EditorInfo.staticClass = @__class;
			global::android.view.inputmethod.EditorInfo._dump9765 = @__env.GetMethodID(global::android.view.inputmethod.EditorInfo.staticClass, "dump", "(Landroid/util/Printer;Ljava/lang/String;)V");
			global::android.view.inputmethod.EditorInfo._writeToParcel9766 = @__env.GetMethodID(global::android.view.inputmethod.EditorInfo.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
			global::android.view.inputmethod.EditorInfo._describeContents9767 = @__env.GetMethodID(global::android.view.inputmethod.EditorInfo.staticClass, "describeContents", "()I");
			global::android.view.inputmethod.EditorInfo._EditorInfo9768 = @__env.GetMethodID(global::android.view.inputmethod.EditorInfo.staticClass, "<init>", "()V");
		}
	}
}
