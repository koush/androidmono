namespace android.widget
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class TextView : android.view.View, android.view.ViewTreeObserver.OnPreDrawListener
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static TextView()
		{
			InitJNI();
		}
		protected TextView(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaClass()]
		public sealed partial class BufferType : java.lang.Enum
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static BufferType()
			{
				InitJNI();
			}
			internal BufferType(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _values17852;
			public static global::android.widget.TextView.BufferType[] values() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<android.widget.TextView.BufferType>(@__env.CallStaticObjectMethod(android.widget.TextView.BufferType.staticClass, global::android.widget.TextView.BufferType._values17852)) as android.widget.TextView.BufferType[];
			}
			internal static global::MonoJavaBridge.MethodId _valueOf17853;
			public static global::android.widget.TextView.BufferType valueOf(java.lang.String arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.widget.TextView.BufferType>(@__env.CallStaticObjectMethod(android.widget.TextView.BufferType.staticClass, global::android.widget.TextView.BufferType._valueOf17853, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.widget.TextView.BufferType;
			}
			internal static global::MonoJavaBridge.FieldId _EDITABLE17854;
			public static global::android.widget.TextView.BufferType EDITABLE
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.widget.TextView.BufferType>(@__env.GetStaticObjectField(global::android.widget.TextView.BufferType.staticClass, _EDITABLE17854)) as android.widget.TextView.BufferType;
				}
			}
			internal static global::MonoJavaBridge.FieldId _NORMAL17855;
			public static global::android.widget.TextView.BufferType NORMAL
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.widget.TextView.BufferType>(@__env.GetStaticObjectField(global::android.widget.TextView.BufferType.staticClass, _NORMAL17855)) as android.widget.TextView.BufferType;
				}
			}
			internal static global::MonoJavaBridge.FieldId _SPANNABLE17856;
			public static global::android.widget.TextView.BufferType SPANNABLE
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.widget.TextView.BufferType>(@__env.GetStaticObjectField(global::android.widget.TextView.BufferType.staticClass, _SPANNABLE17856)) as android.widget.TextView.BufferType;
				}
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.widget.TextView.BufferType.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/TextView$BufferType"));
				global::android.widget.TextView.BufferType._values17852 = @__env.GetStaticMethodIDNoThrow(global::android.widget.TextView.BufferType.staticClass, "values", "()[Landroid/widget/TextView/BufferType;");
				global::android.widget.TextView.BufferType._valueOf17853 = @__env.GetStaticMethodIDNoThrow(global::android.widget.TextView.BufferType.staticClass, "valueOf", "(Ljava/lang/String;)Landroid/widget/TextView$BufferType;");
				global::android.widget.TextView.BufferType._EDITABLE17854 = @__env.GetStaticFieldIDNoThrow(global::android.widget.TextView.BufferType.staticClass, "EDITABLE", "Landroid/widget/TextView$BufferType;");
				global::android.widget.TextView.BufferType._NORMAL17855 = @__env.GetStaticFieldIDNoThrow(global::android.widget.TextView.BufferType.staticClass, "NORMAL", "Landroid/widget/TextView$BufferType;");
				global::android.widget.TextView.BufferType._SPANNABLE17856 = @__env.GetStaticFieldIDNoThrow(global::android.widget.TextView.BufferType.staticClass, "SPANNABLE", "Landroid/widget/TextView$BufferType;");
			}
		}
		[global::MonoJavaBridge.JavaInterface(typeof(global::android.widget.TextView.OnEditorActionListener_))]
		public partial interface OnEditorActionListener  : global::MonoJavaBridge.IJavaObject 
		{
			bool onEditorAction(android.widget.TextView arg0, int arg1, android.view.KeyEvent arg2);
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.widget.TextView.OnEditorActionListener))]
		public sealed partial class OnEditorActionListener_ : java.lang.Object, OnEditorActionListener
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static OnEditorActionListener_()
			{
				InitJNI();
			}
			internal OnEditorActionListener_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _onEditorAction17857;
			 bool android.widget.TextView.OnEditorActionListener.onEditorAction(android.widget.TextView arg0, int arg1, android.view.KeyEvent arg2) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.TextView.OnEditorActionListener_._onEditorAction17857, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
				else
					return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.TextView.OnEditorActionListener_.staticClass, global::android.widget.TextView.OnEditorActionListener_._onEditorAction17857, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.widget.TextView.OnEditorActionListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/TextView$OnEditorActionListener"));
				global::android.widget.TextView.OnEditorActionListener_._onEditorAction17857 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.OnEditorActionListener_.staticClass, "onEditorAction", "(Landroid/widget/TextView;ILandroid/view/KeyEvent;)Z");
			}
		}
		[global::MonoJavaBridge.JavaClass()]
		public partial class SavedState : android.view.View.BaseSavedState
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static SavedState()
			{
				InitJNI();
			}
			protected SavedState(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _toString17858;
			public override global::java.lang.String toString() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.TextView.SavedState._toString17858)) as java.lang.String;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.TextView.SavedState.staticClass, global::android.widget.TextView.SavedState._toString17858)) as java.lang.String;
			}
			internal static global::MonoJavaBridge.MethodId _writeToParcel17859;
			public override void writeToParcel(android.os.Parcel arg0, int arg1) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView.SavedState._writeToParcel17859, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.SavedState.staticClass, global::android.widget.TextView.SavedState._writeToParcel17859, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			internal static global::MonoJavaBridge.FieldId _CREATOR17860;
			public static global::android.os.Parcelable_Creator CREATOR
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.Parcelable_Creator>(@__env.GetStaticObjectField(global::android.widget.TextView.SavedState.staticClass, _CREATOR17860)) as android.os.Parcelable_Creator;
				}
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.widget.TextView.SavedState.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/TextView$SavedState"));
				global::android.widget.TextView.SavedState._toString17858 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.SavedState.staticClass, "toString", "()Ljava/lang/String;");
				global::android.widget.TextView.SavedState._writeToParcel17859 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.SavedState.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
				global::android.widget.TextView.SavedState._CREATOR17860 = @__env.GetStaticFieldIDNoThrow(global::android.widget.TextView.SavedState.staticClass, "CREATOR", "Landroid/os/Parcelable$Creator;");
			}
		}
		internal static global::MonoJavaBridge.MethodId _append17861;
		public virtual void append(java.lang.CharSequence arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._append17861, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._append17861, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public void append(string arg0)
		{
			append((global::java.lang.CharSequence)(global::java.lang.String)arg0);
		}
		internal static global::MonoJavaBridge.MethodId _append17862;
		public virtual void append(java.lang.CharSequence arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._append17862, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._append17862, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		public void append(string arg0, int arg1, int arg2)
		{
			append((global::java.lang.CharSequence)(global::java.lang.String)arg0, arg1, arg2);
		}
		internal static global::MonoJavaBridge.MethodId _length17863;
		public virtual int length() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.TextView._length17863);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._length17863);
		}
		internal static global::MonoJavaBridge.MethodId _debug17864;
		public virtual void debug(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._debug17864, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._debug17864, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setError17865;
		public virtual void setError(java.lang.CharSequence arg0, android.graphics.drawable.Drawable arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._setError17865, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._setError17865, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public void setError(string arg0, android.graphics.drawable.Drawable arg1)
		{
			setError((global::java.lang.CharSequence)(global::java.lang.String)arg0, arg1);
		}
		internal static global::MonoJavaBridge.MethodId _setError17866;
		public virtual void setError(java.lang.CharSequence arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._setError17866, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._setError17866, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public void setError(string arg0)
		{
			setError((global::java.lang.CharSequence)(global::java.lang.String)arg0);
		}
		internal static global::MonoJavaBridge.MethodId _setText17867;
		public virtual void setText(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._setText17867, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._setText17867, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setText17868;
		public virtual void setText(java.lang.CharSequence arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._setText17868, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._setText17868, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public void setText(string arg0)
		{
			setText((global::java.lang.CharSequence)(global::java.lang.String)arg0);
		}
		internal static global::MonoJavaBridge.MethodId _setText17869;
		public virtual void setText(java.lang.CharSequence arg0, android.widget.TextView.BufferType arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._setText17869, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._setText17869, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public void setText(string arg0, android.widget.TextView.BufferType arg1)
		{
			setText((global::java.lang.CharSequence)(global::java.lang.String)arg0, arg1);
		}
		internal static global::MonoJavaBridge.MethodId _setText17870;
		public virtual void setText(char[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._setText17870, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._setText17870, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setText17871;
		public virtual void setText(int arg0, android.widget.TextView.BufferType arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._setText17871, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._setText17871, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public new string Text
		{
			get
			{
				return getText().toString();
			}
			set
			{
				setText((global::java.lang.CharSequence)(global::java.lang.String)value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getText17872;
		public virtual global::java.lang.CharSequence getText() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.TextView._getText17872)) as java.lang.CharSequence;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._getText17872)) as java.lang.CharSequence;
		}
		public new global::android.text.Layout Layout
		{
			get
			{
				return getLayout();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getLayout17873;
		public virtual global::android.text.Layout getLayout() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.TextView._getLayout17873)) as android.text.Layout;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._getLayout17873)) as android.text.Layout;
		}
		internal static global::MonoJavaBridge.MethodId _onRestoreInstanceState17874;
		public virtual void onRestoreInstanceState(android.os.Parcelable arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._onRestoreInstanceState17874, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._onRestoreInstanceState17874, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onSaveInstanceState17875;
		public virtual global::android.os.Parcelable onSaveInstanceState() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.Parcelable>(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.TextView._onSaveInstanceState17875)) as android.os.Parcelable;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.Parcelable>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._onSaveInstanceState17875)) as android.os.Parcelable;
		}
		internal static global::MonoJavaBridge.MethodId _onKeyDown17876;
		public override bool onKeyDown(int arg0, android.view.KeyEvent arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.TextView._onKeyDown17876, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._onKeyDown17876, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _onKeyUp17877;
		public override bool onKeyUp(int arg0, android.view.KeyEvent arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.TextView._onKeyUp17877, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._onKeyUp17877, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _onKeyMultiple17878;
		public override bool onKeyMultiple(int arg0, int arg1, android.view.KeyEvent arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.TextView._onKeyMultiple17878, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._onKeyMultiple17878, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _onTouchEvent17879;
		public override bool onTouchEvent(android.view.MotionEvent arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.TextView._onTouchEvent17879, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._onTouchEvent17879, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onTrackballEvent17880;
		public override bool onTrackballEvent(android.view.MotionEvent arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.TextView._onTrackballEvent17880, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._onTrackballEvent17880, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onWindowFocusChanged17881;
		public override void onWindowFocusChanged(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._onWindowFocusChanged17881, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._onWindowFocusChanged17881, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onAttachedToWindow17882;
		protected override void onAttachedToWindow() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._onAttachedToWindow17882);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._onAttachedToWindow17882);
		}
		internal static global::MonoJavaBridge.MethodId _onDetachedFromWindow17883;
		protected override void onDetachedFromWindow() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._onDetachedFromWindow17883);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._onDetachedFromWindow17883);
		}
		internal static global::MonoJavaBridge.MethodId _dispatchPopulateAccessibilityEvent17884;
		public override bool dispatchPopulateAccessibilityEvent(android.view.accessibility.AccessibilityEvent arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.TextView._dispatchPopulateAccessibilityEvent17884, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._dispatchPopulateAccessibilityEvent17884, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onCreateContextMenu17885;
		protected override void onCreateContextMenu(android.view.ContextMenu arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._onCreateContextMenu17885, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._onCreateContextMenu17885, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setGravity17886;
		public virtual void setGravity(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._setGravity17886, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._setGravity17886, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _performLongClick17887;
		public override bool performLongClick() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.TextView._performLongClick17887);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._performLongClick17887);
		}
		internal static global::MonoJavaBridge.MethodId _onFocusChanged17888;
		protected override void onFocusChanged(bool arg0, int arg1, android.graphics.Rect arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._onFocusChanged17888, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._onFocusChanged17888, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _onStartTemporaryDetach17889;
		public override void onStartTemporaryDetach() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._onStartTemporaryDetach17889);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._onStartTemporaryDetach17889);
		}
		internal static global::MonoJavaBridge.MethodId _onFinishTemporaryDetach17890;
		public override void onFinishTemporaryDetach() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._onFinishTemporaryDetach17890);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._onFinishTemporaryDetach17890);
		}
		internal static global::MonoJavaBridge.MethodId _onKeyShortcut17891;
		public override bool onKeyShortcut(int arg0, android.view.KeyEvent arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.TextView._onKeyShortcut17891, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._onKeyShortcut17891, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _onCheckIsTextEditor17892;
		public override bool onCheckIsTextEditor() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.TextView._onCheckIsTextEditor17892);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._onCheckIsTextEditor17892);
		}
		internal static global::MonoJavaBridge.MethodId _onCreateInputConnection17893;
		public override global::android.view.inputmethod.InputConnection onCreateInputConnection(android.view.inputmethod.EditorInfo arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.inputmethod.InputConnection>(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.TextView._onCreateInputConnection17893, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.inputmethod.InputConnection;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.inputmethod.InputConnection>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._onCreateInputConnection17893, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.inputmethod.InputConnection;
		}
		internal static global::MonoJavaBridge.MethodId _cancelLongPress17894;
		public override void cancelLongPress() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._cancelLongPress17894);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._cancelLongPress17894);
		}
		internal static global::MonoJavaBridge.MethodId _getFocusedRect17895;
		public override void getFocusedRect(android.graphics.Rect arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._getFocusedRect17895, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._getFocusedRect17895, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _computeScroll17896;
		public override void computeScroll() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._computeScroll17896);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._computeScroll17896);
		}
		protected new float LeftFadingEdgeStrength
		{
			get
			{
				return getLeftFadingEdgeStrength();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getLeftFadingEdgeStrength17897;
		protected override float getLeftFadingEdgeStrength() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.widget.TextView._getLeftFadingEdgeStrength17897);
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._getLeftFadingEdgeStrength17897);
		}
		protected new float RightFadingEdgeStrength
		{
			get
			{
				return getRightFadingEdgeStrength();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getRightFadingEdgeStrength17898;
		protected override float getRightFadingEdgeStrength() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.widget.TextView._getRightFadingEdgeStrength17898);
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._getRightFadingEdgeStrength17898);
		}
		internal static global::MonoJavaBridge.MethodId _computeHorizontalScrollRange17899;
		protected override int computeHorizontalScrollRange() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.TextView._computeHorizontalScrollRange17899);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._computeHorizontalScrollRange17899);
		}
		internal static global::MonoJavaBridge.MethodId _computeVerticalScrollRange17900;
		protected override int computeVerticalScrollRange() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.TextView._computeVerticalScrollRange17900);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._computeVerticalScrollRange17900);
		}
		internal static global::MonoJavaBridge.MethodId _computeVerticalScrollExtent17901;
		protected override int computeVerticalScrollExtent() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.TextView._computeVerticalScrollExtent17901);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._computeVerticalScrollExtent17901);
		}
		internal static global::MonoJavaBridge.MethodId _onDraw17902;
		protected override void onDraw(android.graphics.Canvas arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._onDraw17902, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._onDraw17902, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isPaddingOffsetRequired17903;
		protected override bool isPaddingOffsetRequired() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.TextView._isPaddingOffsetRequired17903);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._isPaddingOffsetRequired17903);
		}
		protected new int LeftPaddingOffset
		{
			get
			{
				return getLeftPaddingOffset();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getLeftPaddingOffset17904;
		protected override int getLeftPaddingOffset() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.TextView._getLeftPaddingOffset17904);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._getLeftPaddingOffset17904);
		}
		protected new int RightPaddingOffset
		{
			get
			{
				return getRightPaddingOffset();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getRightPaddingOffset17905;
		protected override int getRightPaddingOffset() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.TextView._getRightPaddingOffset17905);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._getRightPaddingOffset17905);
		}
		protected new int TopPaddingOffset
		{
			get
			{
				return getTopPaddingOffset();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getTopPaddingOffset17906;
		protected override int getTopPaddingOffset() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.TextView._getTopPaddingOffset17906);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._getTopPaddingOffset17906);
		}
		protected new int BottomPaddingOffset
		{
			get
			{
				return getBottomPaddingOffset();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getBottomPaddingOffset17907;
		protected override int getBottomPaddingOffset() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.TextView._getBottomPaddingOffset17907);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._getBottomPaddingOffset17907);
		}
		internal static global::MonoJavaBridge.MethodId _invalidateDrawable17908;
		public override void invalidateDrawable(android.graphics.drawable.Drawable arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._invalidateDrawable17908, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._invalidateDrawable17908, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _verifyDrawable17909;
		protected override bool verifyDrawable(android.graphics.drawable.Drawable arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.TextView._verifyDrawable17909, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._verifyDrawable17909, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _drawableStateChanged17910;
		protected override void drawableStateChanged() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._drawableStateChanged17910);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._drawableStateChanged17910);
		}
		internal static global::MonoJavaBridge.MethodId _setPadding17911;
		public override void setPadding(int arg0, int arg1, int arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._setPadding17911, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._setPadding17911, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _setSelected17912;
		public override void setSelected(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._setSelected17912, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._setSelected17912, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int Baseline
		{
			get
			{
				return getBaseline();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getBaseline17913;
		public override int getBaseline() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.TextView._getBaseline17913);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._getBaseline17913);
		}
		internal static global::MonoJavaBridge.MethodId _onMeasure17914;
		protected override void onMeasure(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._onMeasure17914, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._onMeasure17914, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setTypeface17915;
		public virtual void setTypeface(android.graphics.Typeface arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._setTypeface17915, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._setTypeface17915, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setTypeface17916;
		public virtual void setTypeface(android.graphics.Typeface arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._setTypeface17916, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._setTypeface17916, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		protected new bool DefaultEditable
		{
			get
			{
				return getDefaultEditable();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getDefaultEditable17917;
		protected virtual bool getDefaultEditable() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.TextView._getDefaultEditable17917);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._getDefaultEditable17917);
		}
		protected new global::android.text.method.MovementMethod DefaultMovementMethod
		{
			get
			{
				return getDefaultMovementMethod();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getDefaultMovementMethod17918;
		protected virtual global::android.text.method.MovementMethod getDefaultMovementMethod() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.text.method.MovementMethod>(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.TextView._getDefaultMovementMethod17918)) as android.text.method.MovementMethod;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.text.method.MovementMethod>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._getDefaultMovementMethod17918)) as android.text.method.MovementMethod;
		}
		public new global::android.text.Editable EditableText
		{
			get
			{
				return getEditableText();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getEditableText17919;
		public virtual global::android.text.Editable getEditableText() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.text.Editable>(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.TextView._getEditableText17919)) as android.text.Editable;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.text.Editable>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._getEditableText17919)) as android.text.Editable;
		}
		public new int LineHeight
		{
			get
			{
				return getLineHeight();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getLineHeight17920;
		public virtual int getLineHeight() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.TextView._getLineHeight17920);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._getLineHeight17920);
		}
		public new global::android.text.method.KeyListener KeyListener
		{
			get
			{
				return getKeyListener();
			}
			set
			{
				setKeyListener(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getKeyListener17921;
		public virtual global::android.text.method.KeyListener getKeyListener() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.text.method.KeyListener>(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.TextView._getKeyListener17921)) as android.text.method.KeyListener;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.text.method.KeyListener>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._getKeyListener17921)) as android.text.method.KeyListener;
		}
		internal static global::MonoJavaBridge.MethodId _setKeyListener17922;
		public virtual void setKeyListener(android.text.method.KeyListener arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._setKeyListener17922, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._setKeyListener17922, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::android.text.method.MovementMethod MovementMethod
		{
			get
			{
				return getMovementMethod();
			}
			set
			{
				setMovementMethod(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getMovementMethod17923;
		public virtual global::android.text.method.MovementMethod getMovementMethod() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.text.method.MovementMethod>(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.TextView._getMovementMethod17923)) as android.text.method.MovementMethod;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.text.method.MovementMethod>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._getMovementMethod17923)) as android.text.method.MovementMethod;
		}
		internal static global::MonoJavaBridge.MethodId _setMovementMethod17924;
		public virtual void setMovementMethod(android.text.method.MovementMethod arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._setMovementMethod17924, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._setMovementMethod17924, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::android.text.method.TransformationMethod TransformationMethod
		{
			get
			{
				return getTransformationMethod();
			}
			set
			{
				setTransformationMethod(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getTransformationMethod17925;
		public virtual global::android.text.method.TransformationMethod getTransformationMethod() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.text.method.TransformationMethod>(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.TextView._getTransformationMethod17925)) as android.text.method.TransformationMethod;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.text.method.TransformationMethod>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._getTransformationMethod17925)) as android.text.method.TransformationMethod;
		}
		internal static global::MonoJavaBridge.MethodId _setTransformationMethod17926;
		public virtual void setTransformationMethod(android.text.method.TransformationMethod arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._setTransformationMethod17926, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._setTransformationMethod17926, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int CompoundPaddingTop
		{
			get
			{
				return getCompoundPaddingTop();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getCompoundPaddingTop17927;
		public virtual int getCompoundPaddingTop() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.TextView._getCompoundPaddingTop17927);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._getCompoundPaddingTop17927);
		}
		public new int CompoundPaddingBottom
		{
			get
			{
				return getCompoundPaddingBottom();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getCompoundPaddingBottom17928;
		public virtual int getCompoundPaddingBottom() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.TextView._getCompoundPaddingBottom17928);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._getCompoundPaddingBottom17928);
		}
		public new int CompoundPaddingLeft
		{
			get
			{
				return getCompoundPaddingLeft();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getCompoundPaddingLeft17929;
		public virtual int getCompoundPaddingLeft() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.TextView._getCompoundPaddingLeft17929);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._getCompoundPaddingLeft17929);
		}
		public new int CompoundPaddingRight
		{
			get
			{
				return getCompoundPaddingRight();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getCompoundPaddingRight17930;
		public virtual int getCompoundPaddingRight() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.TextView._getCompoundPaddingRight17930);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._getCompoundPaddingRight17930);
		}
		public new int ExtendedPaddingTop
		{
			get
			{
				return getExtendedPaddingTop();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getExtendedPaddingTop17931;
		public virtual int getExtendedPaddingTop() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.TextView._getExtendedPaddingTop17931);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._getExtendedPaddingTop17931);
		}
		public new int ExtendedPaddingBottom
		{
			get
			{
				return getExtendedPaddingBottom();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getExtendedPaddingBottom17932;
		public virtual int getExtendedPaddingBottom() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.TextView._getExtendedPaddingBottom17932);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._getExtendedPaddingBottom17932);
		}
		public new int TotalPaddingLeft
		{
			get
			{
				return getTotalPaddingLeft();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getTotalPaddingLeft17933;
		public virtual int getTotalPaddingLeft() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.TextView._getTotalPaddingLeft17933);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._getTotalPaddingLeft17933);
		}
		public new int TotalPaddingRight
		{
			get
			{
				return getTotalPaddingRight();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getTotalPaddingRight17934;
		public virtual int getTotalPaddingRight() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.TextView._getTotalPaddingRight17934);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._getTotalPaddingRight17934);
		}
		public new int TotalPaddingTop
		{
			get
			{
				return getTotalPaddingTop();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getTotalPaddingTop17935;
		public virtual int getTotalPaddingTop() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.TextView._getTotalPaddingTop17935);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._getTotalPaddingTop17935);
		}
		public new int TotalPaddingBottom
		{
			get
			{
				return getTotalPaddingBottom();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getTotalPaddingBottom17936;
		public virtual int getTotalPaddingBottom() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.TextView._getTotalPaddingBottom17936);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._getTotalPaddingBottom17936);
		}
		internal static global::MonoJavaBridge.MethodId _setCompoundDrawables17937;
		public virtual void setCompoundDrawables(android.graphics.drawable.Drawable arg0, android.graphics.drawable.Drawable arg1, android.graphics.drawable.Drawable arg2, android.graphics.drawable.Drawable arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._setCompoundDrawables17937, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._setCompoundDrawables17937, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _setCompoundDrawablesWithIntrinsicBounds17938;
		public virtual void setCompoundDrawablesWithIntrinsicBounds(android.graphics.drawable.Drawable arg0, android.graphics.drawable.Drawable arg1, android.graphics.drawable.Drawable arg2, android.graphics.drawable.Drawable arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._setCompoundDrawablesWithIntrinsicBounds17938, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._setCompoundDrawablesWithIntrinsicBounds17938, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _setCompoundDrawablesWithIntrinsicBounds17939;
		public virtual void setCompoundDrawablesWithIntrinsicBounds(int arg0, int arg1, int arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._setCompoundDrawablesWithIntrinsicBounds17939, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._setCompoundDrawablesWithIntrinsicBounds17939, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		public new global::android.graphics.drawable.Drawable[] CompoundDrawables
		{
			get
			{
				return getCompoundDrawables();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getCompoundDrawables17940;
		public virtual global::android.graphics.drawable.Drawable[] getCompoundDrawables() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<android.graphics.drawable.Drawable>(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.TextView._getCompoundDrawables17940)) as android.graphics.drawable.Drawable[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<android.graphics.drawable.Drawable>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._getCompoundDrawables17940)) as android.graphics.drawable.Drawable[];
		}
		internal static global::MonoJavaBridge.MethodId _setCompoundDrawablePadding17941;
		public virtual void setCompoundDrawablePadding(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._setCompoundDrawablePadding17941, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._setCompoundDrawablePadding17941, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int CompoundDrawablePadding
		{
			get
			{
				return getCompoundDrawablePadding();
			}
			set
			{
				setCompoundDrawablePadding(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getCompoundDrawablePadding17942;
		public virtual int getCompoundDrawablePadding() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.TextView._getCompoundDrawablePadding17942);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._getCompoundDrawablePadding17942);
		}
		public new int AutoLinkMask
		{
			get
			{
				return getAutoLinkMask();
			}
			set
			{
				setAutoLinkMask(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getAutoLinkMask17943;
		public virtual int getAutoLinkMask() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.TextView._getAutoLinkMask17943);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._getAutoLinkMask17943);
		}
		internal static global::MonoJavaBridge.MethodId _setTextAppearance17944;
		public virtual void setTextAppearance(android.content.Context arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._setTextAppearance17944, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._setTextAppearance17944, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public new float TextSize
		{
			get
			{
				return getTextSize();
			}
			set
			{
				setTextSize(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getTextSize17945;
		public virtual float getTextSize() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.widget.TextView._getTextSize17945);
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._getTextSize17945);
		}
		internal static global::MonoJavaBridge.MethodId _setTextSize17946;
		public virtual void setTextSize(int arg0, float arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._setTextSize17946, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._setTextSize17946, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setTextSize17947;
		public virtual void setTextSize(float arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._setTextSize17947, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._setTextSize17947, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new float TextScaleX
		{
			get
			{
				return getTextScaleX();
			}
			set
			{
				setTextScaleX(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getTextScaleX17948;
		public virtual float getTextScaleX() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.widget.TextView._getTextScaleX17948);
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._getTextScaleX17948);
		}
		internal static global::MonoJavaBridge.MethodId _setTextScaleX17949;
		public virtual void setTextScaleX(float arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._setTextScaleX17949, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._setTextScaleX17949, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::android.graphics.Typeface Typeface
		{
			get
			{
				return getTypeface();
			}
			set
			{
				setTypeface(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getTypeface17950;
		public virtual global::android.graphics.Typeface getTypeface() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.TextView._getTypeface17950)) as android.graphics.Typeface;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._getTypeface17950)) as android.graphics.Typeface;
		}
		internal static global::MonoJavaBridge.MethodId _setTextColor17951;
		public virtual void setTextColor(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._setTextColor17951, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._setTextColor17951, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setTextColor17952;
		public virtual void setTextColor(android.content.res.ColorStateList arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._setTextColor17952, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._setTextColor17952, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::android.content.res.ColorStateList TextColors
		{
			get
			{
				return getTextColors();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getTextColors17953;
		public virtual global::android.content.res.ColorStateList getTextColors() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.TextView._getTextColors17953)) as android.content.res.ColorStateList;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._getTextColors17953)) as android.content.res.ColorStateList;
		}
		internal static global::MonoJavaBridge.MethodId _getTextColors17954;
		public static global::android.content.res.ColorStateList getTextColors(android.content.Context arg0, android.content.res.TypedArray arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.widget.TextView.staticClass, global::android.widget.TextView._getTextColors17954, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.res.ColorStateList;
		}
		public new int CurrentTextColor
		{
			get
			{
				return getCurrentTextColor();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getCurrentTextColor17955;
		public virtual int getCurrentTextColor() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.TextView._getCurrentTextColor17955);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._getCurrentTextColor17955);
		}
		internal static global::MonoJavaBridge.MethodId _setHighlightColor17956;
		public virtual void setHighlightColor(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._setHighlightColor17956, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._setHighlightColor17956, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setShadowLayer17957;
		public virtual void setShadowLayer(float arg0, float arg1, float arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._setShadowLayer17957, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._setShadowLayer17957, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		public new global::android.text.TextPaint Paint
		{
			get
			{
				return getPaint();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getPaint17958;
		public virtual global::android.text.TextPaint getPaint() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.TextView._getPaint17958)) as android.text.TextPaint;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._getPaint17958)) as android.text.TextPaint;
		}
		internal static global::MonoJavaBridge.MethodId _setAutoLinkMask17959;
		public virtual void setAutoLinkMask(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._setAutoLinkMask17959, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._setAutoLinkMask17959, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setLinksClickable17960;
		public virtual void setLinksClickable(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._setLinksClickable17960, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._setLinksClickable17960, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new bool LinksClickable
		{
			get
			{
				return getLinksClickable();
			}
			set
			{
				setLinksClickable(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getLinksClickable17961;
		public virtual bool getLinksClickable() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.TextView._getLinksClickable17961);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._getLinksClickable17961);
		}
		public new global::android.text.style.URLSpan[] Urls
		{
			get
			{
				return getUrls();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getUrls17962;
		public virtual global::android.text.style.URLSpan[] getUrls() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<android.text.style.URLSpan>(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.TextView._getUrls17962)) as android.text.style.URLSpan[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<android.text.style.URLSpan>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._getUrls17962)) as android.text.style.URLSpan[];
		}
		internal static global::MonoJavaBridge.MethodId _setHintTextColor17963;
		public virtual void setHintTextColor(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._setHintTextColor17963, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._setHintTextColor17963, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setHintTextColor17964;
		public virtual void setHintTextColor(android.content.res.ColorStateList arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._setHintTextColor17964, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._setHintTextColor17964, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::android.content.res.ColorStateList HintTextColors
		{
			get
			{
				return getHintTextColors();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getHintTextColors17965;
		public virtual global::android.content.res.ColorStateList getHintTextColors() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.TextView._getHintTextColors17965)) as android.content.res.ColorStateList;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._getHintTextColors17965)) as android.content.res.ColorStateList;
		}
		public new int CurrentHintTextColor
		{
			get
			{
				return getCurrentHintTextColor();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getCurrentHintTextColor17966;
		public virtual int getCurrentHintTextColor() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.TextView._getCurrentHintTextColor17966);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._getCurrentHintTextColor17966);
		}
		internal static global::MonoJavaBridge.MethodId _setLinkTextColor17967;
		public virtual void setLinkTextColor(android.content.res.ColorStateList arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._setLinkTextColor17967, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._setLinkTextColor17967, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setLinkTextColor17968;
		public virtual void setLinkTextColor(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._setLinkTextColor17968, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._setLinkTextColor17968, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::android.content.res.ColorStateList LinkTextColors
		{
			get
			{
				return getLinkTextColors();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getLinkTextColors17969;
		public virtual global::android.content.res.ColorStateList getLinkTextColors() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.TextView._getLinkTextColors17969)) as android.content.res.ColorStateList;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._getLinkTextColors17969)) as android.content.res.ColorStateList;
		}
		public new int Gravity
		{
			get
			{
				return getGravity();
			}
			set
			{
				setGravity(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getGravity17970;
		public virtual int getGravity() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.TextView._getGravity17970);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._getGravity17970);
		}
		public new int PaintFlags
		{
			get
			{
				return getPaintFlags();
			}
			set
			{
				setPaintFlags(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getPaintFlags17971;
		public virtual int getPaintFlags() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.TextView._getPaintFlags17971);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._getPaintFlags17971);
		}
		internal static global::MonoJavaBridge.MethodId _setPaintFlags17972;
		public virtual void setPaintFlags(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._setPaintFlags17972, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._setPaintFlags17972, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setHorizontallyScrolling17973;
		public virtual void setHorizontallyScrolling(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._setHorizontallyScrolling17973, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._setHorizontallyScrolling17973, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setMinLines17974;
		public virtual void setMinLines(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._setMinLines17974, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._setMinLines17974, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setMinHeight17975;
		public virtual void setMinHeight(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._setMinHeight17975, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._setMinHeight17975, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setMaxLines17976;
		public virtual void setMaxLines(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._setMaxLines17976, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._setMaxLines17976, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setMaxHeight17977;
		public virtual void setMaxHeight(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._setMaxHeight17977, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._setMaxHeight17977, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setLines17978;
		public virtual void setLines(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._setLines17978, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._setLines17978, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setHeight17979;
		public virtual void setHeight(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._setHeight17979, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._setHeight17979, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setMinEms17980;
		public virtual void setMinEms(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._setMinEms17980, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._setMinEms17980, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setMinWidth17981;
		public virtual void setMinWidth(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._setMinWidth17981, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._setMinWidth17981, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setMaxEms17982;
		public virtual void setMaxEms(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._setMaxEms17982, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._setMaxEms17982, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setMaxWidth17983;
		public virtual void setMaxWidth(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._setMaxWidth17983, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._setMaxWidth17983, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setEms17984;
		public virtual void setEms(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._setEms17984, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._setEms17984, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setWidth17985;
		public virtual void setWidth(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._setWidth17985, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._setWidth17985, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setLineSpacing17986;
		public virtual void setLineSpacing(float arg0, float arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._setLineSpacing17986, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._setLineSpacing17986, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setFreezesText17987;
		public virtual void setFreezesText(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._setFreezesText17987, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._setFreezesText17987, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new bool FreezesText
		{
			get
			{
				return getFreezesText();
			}
			set
			{
				setFreezesText(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getFreezesText17988;
		public virtual bool getFreezesText() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.TextView._getFreezesText17988);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._getFreezesText17988);
		}
		internal static global::MonoJavaBridge.MethodId _setEditableFactory17989;
		public virtual void setEditableFactory(android.text.Editable_Factory arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._setEditableFactory17989, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._setEditableFactory17989, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setSpannableFactory17990;
		public virtual void setSpannableFactory(android.text.Spannable_Factory arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._setSpannableFactory17990, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._setSpannableFactory17990, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setTextKeepState17991;
		public virtual void setTextKeepState(java.lang.CharSequence arg0, android.widget.TextView.BufferType arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._setTextKeepState17991, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._setTextKeepState17991, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public void setTextKeepState(string arg0, android.widget.TextView.BufferType arg1)
		{
			setTextKeepState((global::java.lang.CharSequence)(global::java.lang.String)arg0, arg1);
		}
		internal static global::MonoJavaBridge.MethodId _setTextKeepState17992;
		public virtual void setTextKeepState(java.lang.CharSequence arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._setTextKeepState17992, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._setTextKeepState17992, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public void setTextKeepState(string arg0)
		{
			setTextKeepState((global::java.lang.CharSequence)(global::java.lang.String)arg0);
		}
		internal static global::MonoJavaBridge.MethodId _setHint17993;
		public virtual void setHint(java.lang.CharSequence arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._setHint17993, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._setHint17993, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public void setHint(string arg0)
		{
			setHint((global::java.lang.CharSequence)(global::java.lang.String)arg0);
		}
		internal static global::MonoJavaBridge.MethodId _setHint17994;
		public virtual void setHint(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._setHint17994, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._setHint17994, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new string Hint
		{
			get
			{
				return getHint().toString();
			}
			set
			{
				setHint((global::java.lang.CharSequence)(global::java.lang.String)value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getHint17995;
		public virtual global::java.lang.CharSequence getHint() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.TextView._getHint17995)) as java.lang.CharSequence;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._getHint17995)) as java.lang.CharSequence;
		}
		internal static global::MonoJavaBridge.MethodId _setInputType17996;
		public virtual void setInputType(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._setInputType17996, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._setInputType17996, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setRawInputType17997;
		public virtual void setRawInputType(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._setRawInputType17997, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._setRawInputType17997, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int InputType
		{
			get
			{
				return getInputType();
			}
			set
			{
				setInputType(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getInputType17998;
		public virtual int getInputType() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.TextView._getInputType17998);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._getInputType17998);
		}
		internal static global::MonoJavaBridge.MethodId _setImeOptions17999;
		public virtual void setImeOptions(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._setImeOptions17999, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._setImeOptions17999, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int ImeOptions
		{
			get
			{
				return getImeOptions();
			}
			set
			{
				setImeOptions(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getImeOptions18000;
		public virtual int getImeOptions() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.TextView._getImeOptions18000);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._getImeOptions18000);
		}
		internal static global::MonoJavaBridge.MethodId _setImeActionLabel18001;
		public virtual void setImeActionLabel(java.lang.CharSequence arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._setImeActionLabel18001, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._setImeActionLabel18001, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public void setImeActionLabel(string arg0, int arg1)
		{
			setImeActionLabel((global::java.lang.CharSequence)(global::java.lang.String)arg0, arg1);
		}
		public new string ImeActionLabel
		{
			get
			{
				return getImeActionLabel().toString();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getImeActionLabel18002;
		public virtual global::java.lang.CharSequence getImeActionLabel() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.TextView._getImeActionLabel18002)) as java.lang.CharSequence;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._getImeActionLabel18002)) as java.lang.CharSequence;
		}
		public new int ImeActionId
		{
			get
			{
				return getImeActionId();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getImeActionId18003;
		public virtual int getImeActionId() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.TextView._getImeActionId18003);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._getImeActionId18003);
		}
		internal static global::MonoJavaBridge.MethodId _setOnEditorActionListener18004;
		public virtual void setOnEditorActionListener(android.widget.TextView.OnEditorActionListener arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._setOnEditorActionListener18004, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._setOnEditorActionListener18004, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onEditorAction18005;
		public virtual void onEditorAction(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._onEditorAction18005, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._onEditorAction18005, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setPrivateImeOptions18006;
		public virtual void setPrivateImeOptions(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._setPrivateImeOptions18006, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._setPrivateImeOptions18006, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::java.lang.String PrivateImeOptions
		{
			get
			{
				return getPrivateImeOptions();
			}
			set
			{
				setPrivateImeOptions(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getPrivateImeOptions18007;
		public virtual global::java.lang.String getPrivateImeOptions() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.TextView._getPrivateImeOptions18007)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._getPrivateImeOptions18007)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _setInputExtras18008;
		public virtual void setInputExtras(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._setInputExtras18008, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._setInputExtras18008, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getInputExtras18009;
		public virtual global::android.os.Bundle getInputExtras(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.os.Bundle>(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.TextView._getInputExtras18009, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.os.Bundle;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.os.Bundle>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._getInputExtras18009, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.os.Bundle;
		}
		public new string Error
		{
			get
			{
				return getError().toString();
			}
			set
			{
				setError((global::java.lang.CharSequence)(global::java.lang.String)value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getError18010;
		public virtual global::java.lang.CharSequence getError() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.TextView._getError18010)) as java.lang.CharSequence;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._getError18010)) as java.lang.CharSequence;
		}
		internal static global::MonoJavaBridge.MethodId _setFrame18011;
		protected virtual bool setFrame(int arg0, int arg1, int arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.TextView._setFrame18011, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._setFrame18011, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _setFilters18012;
		public virtual void setFilters(android.text.InputFilter[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._setFilters18012, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._setFilters18012, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::android.text.InputFilter[] Filters
		{
			get
			{
				return getFilters();
			}
			set
			{
				setFilters(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getFilters18013;
		public virtual global::android.text.InputFilter[] getFilters() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<android.text.InputFilter>(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.TextView._getFilters18013)) as android.text.InputFilter[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<android.text.InputFilter>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._getFilters18013)) as android.text.InputFilter[];
		}
		internal static global::MonoJavaBridge.MethodId _onPreDraw18014;
		public virtual bool onPreDraw() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.TextView._onPreDraw18014);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._onPreDraw18014);
		}
		public new int LineCount
		{
			get
			{
				return getLineCount();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getLineCount18015;
		public virtual int getLineCount() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.TextView._getLineCount18015);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._getLineCount18015);
		}
		internal static global::MonoJavaBridge.MethodId _getLineBounds18016;
		public virtual int getLineBounds(int arg0, android.graphics.Rect arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.TextView._getLineBounds18016, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._getLineBounds18016, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _extractText18017;
		public virtual bool extractText(android.view.inputmethod.ExtractedTextRequest arg0, android.view.inputmethod.ExtractedText arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.TextView._extractText18017, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._extractText18017, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setExtractedText18018;
		public virtual void setExtractedText(android.view.inputmethod.ExtractedText arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._setExtractedText18018, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._setExtractedText18018, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onCommitCompletion18019;
		public virtual void onCommitCompletion(android.view.inputmethod.CompletionInfo arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._onCommitCompletion18019, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._onCommitCompletion18019, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _beginBatchEdit18020;
		public virtual void beginBatchEdit() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._beginBatchEdit18020);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._beginBatchEdit18020);
		}
		internal static global::MonoJavaBridge.MethodId _endBatchEdit18021;
		public virtual void endBatchEdit() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._endBatchEdit18021);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._endBatchEdit18021);
		}
		internal static global::MonoJavaBridge.MethodId _onBeginBatchEdit18022;
		public virtual void onBeginBatchEdit() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._onBeginBatchEdit18022);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._onBeginBatchEdit18022);
		}
		internal static global::MonoJavaBridge.MethodId _onEndBatchEdit18023;
		public virtual void onEndBatchEdit() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._onEndBatchEdit18023);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._onEndBatchEdit18023);
		}
		internal static global::MonoJavaBridge.MethodId _onPrivateIMECommand18024;
		public virtual bool onPrivateIMECommand(java.lang.String arg0, android.os.Bundle arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.TextView._onPrivateIMECommand18024, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._onPrivateIMECommand18024, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setIncludeFontPadding18025;
		public virtual void setIncludeFontPadding(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._setIncludeFontPadding18025, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._setIncludeFontPadding18025, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _bringPointIntoView18026;
		public virtual bool bringPointIntoView(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.TextView._bringPointIntoView18026, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._bringPointIntoView18026, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _moveCursorToVisibleOffset18027;
		public virtual bool moveCursorToVisibleOffset() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.TextView._moveCursorToVisibleOffset18027);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._moveCursorToVisibleOffset18027);
		}
		public new int SelectionStart
		{
			get
			{
				return getSelectionStart();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getSelectionStart18028;
		public virtual int getSelectionStart() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.TextView._getSelectionStart18028);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._getSelectionStart18028);
		}
		public new int SelectionEnd
		{
			get
			{
				return getSelectionEnd();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getSelectionEnd18029;
		public virtual int getSelectionEnd() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.TextView._getSelectionEnd18029);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._getSelectionEnd18029);
		}
		internal static global::MonoJavaBridge.MethodId _hasSelection18030;
		public virtual bool hasSelection() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.TextView._hasSelection18030);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._hasSelection18030);
		}
		internal static global::MonoJavaBridge.MethodId _setSingleLine18031;
		public virtual void setSingleLine() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._setSingleLine18031);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._setSingleLine18031);
		}
		internal static global::MonoJavaBridge.MethodId _setSingleLine18032;
		public virtual void setSingleLine(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._setSingleLine18032, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._setSingleLine18032, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setEllipsize18033;
		public virtual void setEllipsize(android.text.TextUtils.TruncateAt arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._setEllipsize18033, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._setEllipsize18033, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setMarqueeRepeatLimit18034;
		public virtual void setMarqueeRepeatLimit(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._setMarqueeRepeatLimit18034, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._setMarqueeRepeatLimit18034, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::android.text.TextUtils.TruncateAt Ellipsize
		{
			get
			{
				return getEllipsize();
			}
			set
			{
				setEllipsize(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getEllipsize18035;
		public virtual global::android.text.TextUtils.TruncateAt getEllipsize() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.text.TextUtils.TruncateAt>(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.TextView._getEllipsize18035)) as android.text.TextUtils.TruncateAt;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.text.TextUtils.TruncateAt>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._getEllipsize18035)) as android.text.TextUtils.TruncateAt;
		}
		internal static global::MonoJavaBridge.MethodId _setSelectAllOnFocus18036;
		public virtual void setSelectAllOnFocus(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._setSelectAllOnFocus18036, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._setSelectAllOnFocus18036, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setCursorVisible18037;
		public virtual void setCursorVisible(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._setCursorVisible18037, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._setCursorVisible18037, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onTextChanged18038;
		protected virtual void onTextChanged(java.lang.CharSequence arg0, int arg1, int arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._onTextChanged18038, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._onTextChanged18038, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _onSelectionChanged18039;
		protected virtual void onSelectionChanged(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._onSelectionChanged18039, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._onSelectionChanged18039, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _addTextChangedListener18040;
		public virtual void addTextChangedListener(android.text.TextWatcher arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._addTextChangedListener18040, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._addTextChangedListener18040, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _removeTextChangedListener18041;
		public virtual void removeTextChangedListener(android.text.TextWatcher arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._removeTextChangedListener18041, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._removeTextChangedListener18041, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _clearComposingText18042;
		public virtual void clearComposingText() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._clearComposingText18042);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._clearComposingText18042);
		}
		internal static global::MonoJavaBridge.MethodId _didTouchFocusSelect18043;
		public virtual bool didTouchFocusSelect() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.TextView._didTouchFocusSelect18043);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._didTouchFocusSelect18043);
		}
		internal static global::MonoJavaBridge.MethodId _setScroller18044;
		public virtual void setScroller(android.widget.Scroller arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._setScroller18044, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._setScroller18044, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getTextColor18045;
		public static int getTextColor(android.content.Context arg0, android.content.res.TypedArray arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.widget.TextView.staticClass, global::android.widget.TextView._getTextColor18045, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _isInputMethodTarget18046;
		public virtual bool isInputMethodTarget() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.TextView._isInputMethodTarget18046);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._isInputMethodTarget18046);
		}
		internal static global::MonoJavaBridge.MethodId _onTextContextMenuItem18047;
		public virtual bool onTextContextMenuItem(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.TextView._onTextContextMenuItem18047, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._onTextContextMenuItem18047, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _TextView18048;
		public TextView(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.TextView.staticClass, global::android.widget.TextView._TextView18048, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _TextView18049;
		public TextView(android.content.Context arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.TextView.staticClass, global::android.widget.TextView._TextView18049, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _TextView18050;
		public TextView(android.content.Context arg0, android.util.AttributeSet arg1, int arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.TextView.staticClass, global::android.widget.TextView._TextView18050, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.widget.TextView.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/TextView"));
			global::android.widget.TextView._append17861 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "append", "(Ljava/lang/CharSequence;)V");
			global::android.widget.TextView._append17862 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "append", "(Ljava/lang/CharSequence;II)V");
			global::android.widget.TextView._length17863 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "length", "()I");
			global::android.widget.TextView._debug17864 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "debug", "(I)V");
			global::android.widget.TextView._setError17865 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "setError", "(Ljava/lang/CharSequence;Landroid/graphics/drawable/Drawable;)V");
			global::android.widget.TextView._setError17866 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "setError", "(Ljava/lang/CharSequence;)V");
			global::android.widget.TextView._setText17867 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "setText", "(I)V");
			global::android.widget.TextView._setText17868 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "setText", "(Ljava/lang/CharSequence;)V");
			global::android.widget.TextView._setText17869 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "setText", "(Ljava/lang/CharSequence;Landroid/widget/TextView$BufferType;)V");
			global::android.widget.TextView._setText17870 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "setText", "([CII)V");
			global::android.widget.TextView._setText17871 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "setText", "(ILandroid/widget/TextView$BufferType;)V");
			global::android.widget.TextView._getText17872 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "getText", "()Ljava/lang/CharSequence;");
			global::android.widget.TextView._getLayout17873 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "getLayout", "()Landroid/text/Layout;");
			global::android.widget.TextView._onRestoreInstanceState17874 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "onRestoreInstanceState", "(Landroid/os/Parcelable;)V");
			global::android.widget.TextView._onSaveInstanceState17875 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "onSaveInstanceState", "()Landroid/os/Parcelable;");
			global::android.widget.TextView._onKeyDown17876 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "onKeyDown", "(ILandroid/view/KeyEvent;)Z");
			global::android.widget.TextView._onKeyUp17877 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "onKeyUp", "(ILandroid/view/KeyEvent;)Z");
			global::android.widget.TextView._onKeyMultiple17878 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "onKeyMultiple", "(IILandroid/view/KeyEvent;)Z");
			global::android.widget.TextView._onTouchEvent17879 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "onTouchEvent", "(Landroid/view/MotionEvent;)Z");
			global::android.widget.TextView._onTrackballEvent17880 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "onTrackballEvent", "(Landroid/view/MotionEvent;)Z");
			global::android.widget.TextView._onWindowFocusChanged17881 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "onWindowFocusChanged", "(Z)V");
			global::android.widget.TextView._onAttachedToWindow17882 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "onAttachedToWindow", "()V");
			global::android.widget.TextView._onDetachedFromWindow17883 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "onDetachedFromWindow", "()V");
			global::android.widget.TextView._dispatchPopulateAccessibilityEvent17884 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "dispatchPopulateAccessibilityEvent", "(Landroid/view/accessibility/AccessibilityEvent;)Z");
			global::android.widget.TextView._onCreateContextMenu17885 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "onCreateContextMenu", "(Landroid/view/ContextMenu;)V");
			global::android.widget.TextView._setGravity17886 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "setGravity", "(I)V");
			global::android.widget.TextView._performLongClick17887 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "performLongClick", "()Z");
			global::android.widget.TextView._onFocusChanged17888 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "onFocusChanged", "(ZILandroid/graphics/Rect;)V");
			global::android.widget.TextView._onStartTemporaryDetach17889 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "onStartTemporaryDetach", "()V");
			global::android.widget.TextView._onFinishTemporaryDetach17890 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "onFinishTemporaryDetach", "()V");
			global::android.widget.TextView._onKeyShortcut17891 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "onKeyShortcut", "(ILandroid/view/KeyEvent;)Z");
			global::android.widget.TextView._onCheckIsTextEditor17892 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "onCheckIsTextEditor", "()Z");
			global::android.widget.TextView._onCreateInputConnection17893 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "onCreateInputConnection", "(Landroid/view/inputmethod/EditorInfo;)Landroid/view/inputmethod/InputConnection;");
			global::android.widget.TextView._cancelLongPress17894 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "cancelLongPress", "()V");
			global::android.widget.TextView._getFocusedRect17895 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "getFocusedRect", "(Landroid/graphics/Rect;)V");
			global::android.widget.TextView._computeScroll17896 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "computeScroll", "()V");
			global::android.widget.TextView._getLeftFadingEdgeStrength17897 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "getLeftFadingEdgeStrength", "()F");
			global::android.widget.TextView._getRightFadingEdgeStrength17898 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "getRightFadingEdgeStrength", "()F");
			global::android.widget.TextView._computeHorizontalScrollRange17899 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "computeHorizontalScrollRange", "()I");
			global::android.widget.TextView._computeVerticalScrollRange17900 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "computeVerticalScrollRange", "()I");
			global::android.widget.TextView._computeVerticalScrollExtent17901 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "computeVerticalScrollExtent", "()I");
			global::android.widget.TextView._onDraw17902 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "onDraw", "(Landroid/graphics/Canvas;)V");
			global::android.widget.TextView._isPaddingOffsetRequired17903 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "isPaddingOffsetRequired", "()Z");
			global::android.widget.TextView._getLeftPaddingOffset17904 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "getLeftPaddingOffset", "()I");
			global::android.widget.TextView._getRightPaddingOffset17905 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "getRightPaddingOffset", "()I");
			global::android.widget.TextView._getTopPaddingOffset17906 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "getTopPaddingOffset", "()I");
			global::android.widget.TextView._getBottomPaddingOffset17907 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "getBottomPaddingOffset", "()I");
			global::android.widget.TextView._invalidateDrawable17908 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "invalidateDrawable", "(Landroid/graphics/drawable/Drawable;)V");
			global::android.widget.TextView._verifyDrawable17909 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "verifyDrawable", "(Landroid/graphics/drawable/Drawable;)Z");
			global::android.widget.TextView._drawableStateChanged17910 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "drawableStateChanged", "()V");
			global::android.widget.TextView._setPadding17911 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "setPadding", "(IIII)V");
			global::android.widget.TextView._setSelected17912 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "setSelected", "(Z)V");
			global::android.widget.TextView._getBaseline17913 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "getBaseline", "()I");
			global::android.widget.TextView._onMeasure17914 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "onMeasure", "(II)V");
			global::android.widget.TextView._setTypeface17915 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "setTypeface", "(Landroid/graphics/Typeface;I)V");
			global::android.widget.TextView._setTypeface17916 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "setTypeface", "(Landroid/graphics/Typeface;)V");
			global::android.widget.TextView._getDefaultEditable17917 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "getDefaultEditable", "()Z");
			global::android.widget.TextView._getDefaultMovementMethod17918 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "getDefaultMovementMethod", "()Landroid/text/method/MovementMethod;");
			global::android.widget.TextView._getEditableText17919 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "getEditableText", "()Landroid/text/Editable;");
			global::android.widget.TextView._getLineHeight17920 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "getLineHeight", "()I");
			global::android.widget.TextView._getKeyListener17921 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "getKeyListener", "()Landroid/text/method/KeyListener;");
			global::android.widget.TextView._setKeyListener17922 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "setKeyListener", "(Landroid/text/method/KeyListener;)V");
			global::android.widget.TextView._getMovementMethod17923 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "getMovementMethod", "()Landroid/text/method/MovementMethod;");
			global::android.widget.TextView._setMovementMethod17924 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "setMovementMethod", "(Landroid/text/method/MovementMethod;)V");
			global::android.widget.TextView._getTransformationMethod17925 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "getTransformationMethod", "()Landroid/text/method/TransformationMethod;");
			global::android.widget.TextView._setTransformationMethod17926 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "setTransformationMethod", "(Landroid/text/method/TransformationMethod;)V");
			global::android.widget.TextView._getCompoundPaddingTop17927 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "getCompoundPaddingTop", "()I");
			global::android.widget.TextView._getCompoundPaddingBottom17928 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "getCompoundPaddingBottom", "()I");
			global::android.widget.TextView._getCompoundPaddingLeft17929 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "getCompoundPaddingLeft", "()I");
			global::android.widget.TextView._getCompoundPaddingRight17930 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "getCompoundPaddingRight", "()I");
			global::android.widget.TextView._getExtendedPaddingTop17931 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "getExtendedPaddingTop", "()I");
			global::android.widget.TextView._getExtendedPaddingBottom17932 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "getExtendedPaddingBottom", "()I");
			global::android.widget.TextView._getTotalPaddingLeft17933 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "getTotalPaddingLeft", "()I");
			global::android.widget.TextView._getTotalPaddingRight17934 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "getTotalPaddingRight", "()I");
			global::android.widget.TextView._getTotalPaddingTop17935 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "getTotalPaddingTop", "()I");
			global::android.widget.TextView._getTotalPaddingBottom17936 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "getTotalPaddingBottom", "()I");
			global::android.widget.TextView._setCompoundDrawables17937 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "setCompoundDrawables", "(Landroid/graphics/drawable/Drawable;Landroid/graphics/drawable/Drawable;Landroid/graphics/drawable/Drawable;Landroid/graphics/drawable/Drawable;)V");
			global::android.widget.TextView._setCompoundDrawablesWithIntrinsicBounds17938 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "setCompoundDrawablesWithIntrinsicBounds", "(Landroid/graphics/drawable/Drawable;Landroid/graphics/drawable/Drawable;Landroid/graphics/drawable/Drawable;Landroid/graphics/drawable/Drawable;)V");
			global::android.widget.TextView._setCompoundDrawablesWithIntrinsicBounds17939 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "setCompoundDrawablesWithIntrinsicBounds", "(IIII)V");
			global::android.widget.TextView._getCompoundDrawables17940 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "getCompoundDrawables", "()[Landroid/graphics/drawable/Drawable;");
			global::android.widget.TextView._setCompoundDrawablePadding17941 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "setCompoundDrawablePadding", "(I)V");
			global::android.widget.TextView._getCompoundDrawablePadding17942 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "getCompoundDrawablePadding", "()I");
			global::android.widget.TextView._getAutoLinkMask17943 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "getAutoLinkMask", "()I");
			global::android.widget.TextView._setTextAppearance17944 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "setTextAppearance", "(Landroid/content/Context;I)V");
			global::android.widget.TextView._getTextSize17945 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "getTextSize", "()F");
			global::android.widget.TextView._setTextSize17946 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "setTextSize", "(IF)V");
			global::android.widget.TextView._setTextSize17947 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "setTextSize", "(F)V");
			global::android.widget.TextView._getTextScaleX17948 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "getTextScaleX", "()F");
			global::android.widget.TextView._setTextScaleX17949 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "setTextScaleX", "(F)V");
			global::android.widget.TextView._getTypeface17950 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "getTypeface", "()Landroid/graphics/Typeface;");
			global::android.widget.TextView._setTextColor17951 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "setTextColor", "(I)V");
			global::android.widget.TextView._setTextColor17952 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "setTextColor", "(Landroid/content/res/ColorStateList;)V");
			global::android.widget.TextView._getTextColors17953 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "getTextColors", "()Landroid/content/res/ColorStateList;");
			global::android.widget.TextView._getTextColors17954 = @__env.GetStaticMethodIDNoThrow(global::android.widget.TextView.staticClass, "getTextColors", "(Landroid/content/Context;Landroid/content/res/TypedArray;)Landroid/content/res/ColorStateList;");
			global::android.widget.TextView._getCurrentTextColor17955 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "getCurrentTextColor", "()I");
			global::android.widget.TextView._setHighlightColor17956 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "setHighlightColor", "(I)V");
			global::android.widget.TextView._setShadowLayer17957 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "setShadowLayer", "(FFFI)V");
			global::android.widget.TextView._getPaint17958 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "getPaint", "()Landroid/text/TextPaint;");
			global::android.widget.TextView._setAutoLinkMask17959 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "setAutoLinkMask", "(I)V");
			global::android.widget.TextView._setLinksClickable17960 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "setLinksClickable", "(Z)V");
			global::android.widget.TextView._getLinksClickable17961 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "getLinksClickable", "()Z");
			global::android.widget.TextView._getUrls17962 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "getUrls", "()[Landroid/text/style/URLSpan;");
			global::android.widget.TextView._setHintTextColor17963 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "setHintTextColor", "(I)V");
			global::android.widget.TextView._setHintTextColor17964 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "setHintTextColor", "(Landroid/content/res/ColorStateList;)V");
			global::android.widget.TextView._getHintTextColors17965 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "getHintTextColors", "()Landroid/content/res/ColorStateList;");
			global::android.widget.TextView._getCurrentHintTextColor17966 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "getCurrentHintTextColor", "()I");
			global::android.widget.TextView._setLinkTextColor17967 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "setLinkTextColor", "(Landroid/content/res/ColorStateList;)V");
			global::android.widget.TextView._setLinkTextColor17968 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "setLinkTextColor", "(I)V");
			global::android.widget.TextView._getLinkTextColors17969 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "getLinkTextColors", "()Landroid/content/res/ColorStateList;");
			global::android.widget.TextView._getGravity17970 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "getGravity", "()I");
			global::android.widget.TextView._getPaintFlags17971 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "getPaintFlags", "()I");
			global::android.widget.TextView._setPaintFlags17972 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "setPaintFlags", "(I)V");
			global::android.widget.TextView._setHorizontallyScrolling17973 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "setHorizontallyScrolling", "(Z)V");
			global::android.widget.TextView._setMinLines17974 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "setMinLines", "(I)V");
			global::android.widget.TextView._setMinHeight17975 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "setMinHeight", "(I)V");
			global::android.widget.TextView._setMaxLines17976 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "setMaxLines", "(I)V");
			global::android.widget.TextView._setMaxHeight17977 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "setMaxHeight", "(I)V");
			global::android.widget.TextView._setLines17978 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "setLines", "(I)V");
			global::android.widget.TextView._setHeight17979 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "setHeight", "(I)V");
			global::android.widget.TextView._setMinEms17980 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "setMinEms", "(I)V");
			global::android.widget.TextView._setMinWidth17981 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "setMinWidth", "(I)V");
			global::android.widget.TextView._setMaxEms17982 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "setMaxEms", "(I)V");
			global::android.widget.TextView._setMaxWidth17983 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "setMaxWidth", "(I)V");
			global::android.widget.TextView._setEms17984 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "setEms", "(I)V");
			global::android.widget.TextView._setWidth17985 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "setWidth", "(I)V");
			global::android.widget.TextView._setLineSpacing17986 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "setLineSpacing", "(FF)V");
			global::android.widget.TextView._setFreezesText17987 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "setFreezesText", "(Z)V");
			global::android.widget.TextView._getFreezesText17988 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "getFreezesText", "()Z");
			global::android.widget.TextView._setEditableFactory17989 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "setEditableFactory", "(Landroid/text/Editable$Factory;)V");
			global::android.widget.TextView._setSpannableFactory17990 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "setSpannableFactory", "(Landroid/text/Spannable$Factory;)V");
			global::android.widget.TextView._setTextKeepState17991 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "setTextKeepState", "(Ljava/lang/CharSequence;Landroid/widget/TextView$BufferType;)V");
			global::android.widget.TextView._setTextKeepState17992 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "setTextKeepState", "(Ljava/lang/CharSequence;)V");
			global::android.widget.TextView._setHint17993 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "setHint", "(Ljava/lang/CharSequence;)V");
			global::android.widget.TextView._setHint17994 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "setHint", "(I)V");
			global::android.widget.TextView._getHint17995 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "getHint", "()Ljava/lang/CharSequence;");
			global::android.widget.TextView._setInputType17996 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "setInputType", "(I)V");
			global::android.widget.TextView._setRawInputType17997 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "setRawInputType", "(I)V");
			global::android.widget.TextView._getInputType17998 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "getInputType", "()I");
			global::android.widget.TextView._setImeOptions17999 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "setImeOptions", "(I)V");
			global::android.widget.TextView._getImeOptions18000 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "getImeOptions", "()I");
			global::android.widget.TextView._setImeActionLabel18001 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "setImeActionLabel", "(Ljava/lang/CharSequence;I)V");
			global::android.widget.TextView._getImeActionLabel18002 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "getImeActionLabel", "()Ljava/lang/CharSequence;");
			global::android.widget.TextView._getImeActionId18003 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "getImeActionId", "()I");
			global::android.widget.TextView._setOnEditorActionListener18004 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "setOnEditorActionListener", "(Landroid/widget/TextView$OnEditorActionListener;)V");
			global::android.widget.TextView._onEditorAction18005 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "onEditorAction", "(I)V");
			global::android.widget.TextView._setPrivateImeOptions18006 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "setPrivateImeOptions", "(Ljava/lang/String;)V");
			global::android.widget.TextView._getPrivateImeOptions18007 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "getPrivateImeOptions", "()Ljava/lang/String;");
			global::android.widget.TextView._setInputExtras18008 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "setInputExtras", "(I)V");
			global::android.widget.TextView._getInputExtras18009 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "getInputExtras", "(Z)Landroid/os/Bundle;");
			global::android.widget.TextView._getError18010 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "getError", "()Ljava/lang/CharSequence;");
			global::android.widget.TextView._setFrame18011 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "setFrame", "(IIII)Z");
			global::android.widget.TextView._setFilters18012 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "setFilters", "([Landroid/text/InputFilter;)V");
			global::android.widget.TextView._getFilters18013 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "getFilters", "()[Landroid/text/InputFilter;");
			global::android.widget.TextView._onPreDraw18014 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "onPreDraw", "()Z");
			global::android.widget.TextView._getLineCount18015 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "getLineCount", "()I");
			global::android.widget.TextView._getLineBounds18016 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "getLineBounds", "(ILandroid/graphics/Rect;)I");
			global::android.widget.TextView._extractText18017 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "extractText", "(Landroid/view/inputmethod/ExtractedTextRequest;Landroid/view/inputmethod/ExtractedText;)Z");
			global::android.widget.TextView._setExtractedText18018 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "setExtractedText", "(Landroid/view/inputmethod/ExtractedText;)V");
			global::android.widget.TextView._onCommitCompletion18019 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "onCommitCompletion", "(Landroid/view/inputmethod/CompletionInfo;)V");
			global::android.widget.TextView._beginBatchEdit18020 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "beginBatchEdit", "()V");
			global::android.widget.TextView._endBatchEdit18021 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "endBatchEdit", "()V");
			global::android.widget.TextView._onBeginBatchEdit18022 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "onBeginBatchEdit", "()V");
			global::android.widget.TextView._onEndBatchEdit18023 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "onEndBatchEdit", "()V");
			global::android.widget.TextView._onPrivateIMECommand18024 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "onPrivateIMECommand", "(Ljava/lang/String;Landroid/os/Bundle;)Z");
			global::android.widget.TextView._setIncludeFontPadding18025 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "setIncludeFontPadding", "(Z)V");
			global::android.widget.TextView._bringPointIntoView18026 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "bringPointIntoView", "(I)Z");
			global::android.widget.TextView._moveCursorToVisibleOffset18027 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "moveCursorToVisibleOffset", "()Z");
			global::android.widget.TextView._getSelectionStart18028 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "getSelectionStart", "()I");
			global::android.widget.TextView._getSelectionEnd18029 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "getSelectionEnd", "()I");
			global::android.widget.TextView._hasSelection18030 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "hasSelection", "()Z");
			global::android.widget.TextView._setSingleLine18031 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "setSingleLine", "()V");
			global::android.widget.TextView._setSingleLine18032 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "setSingleLine", "(Z)V");
			global::android.widget.TextView._setEllipsize18033 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "setEllipsize", "(Landroid/text/TextUtils$TruncateAt;)V");
			global::android.widget.TextView._setMarqueeRepeatLimit18034 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "setMarqueeRepeatLimit", "(I)V");
			global::android.widget.TextView._getEllipsize18035 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "getEllipsize", "()Landroid/text/TextUtils$TruncateAt;");
			global::android.widget.TextView._setSelectAllOnFocus18036 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "setSelectAllOnFocus", "(Z)V");
			global::android.widget.TextView._setCursorVisible18037 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "setCursorVisible", "(Z)V");
			global::android.widget.TextView._onTextChanged18038 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "onTextChanged", "(Ljava/lang/CharSequence;III)V");
			global::android.widget.TextView._onSelectionChanged18039 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "onSelectionChanged", "(II)V");
			global::android.widget.TextView._addTextChangedListener18040 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "addTextChangedListener", "(Landroid/text/TextWatcher;)V");
			global::android.widget.TextView._removeTextChangedListener18041 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "removeTextChangedListener", "(Landroid/text/TextWatcher;)V");
			global::android.widget.TextView._clearComposingText18042 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "clearComposingText", "()V");
			global::android.widget.TextView._didTouchFocusSelect18043 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "didTouchFocusSelect", "()Z");
			global::android.widget.TextView._setScroller18044 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "setScroller", "(Landroid/widget/Scroller;)V");
			global::android.widget.TextView._getTextColor18045 = @__env.GetStaticMethodIDNoThrow(global::android.widget.TextView.staticClass, "getTextColor", "(Landroid/content/Context;Landroid/content/res/TypedArray;I)I");
			global::android.widget.TextView._isInputMethodTarget18046 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "isInputMethodTarget", "()Z");
			global::android.widget.TextView._onTextContextMenuItem18047 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "onTextContextMenuItem", "(I)Z");
			global::android.widget.TextView._TextView18048 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			global::android.widget.TextView._TextView18049 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "<init>", "(Landroid/content/Context;)V");
			global::android.widget.TextView._TextView18050 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V");
		}
	}
}
