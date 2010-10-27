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
			internal static global::MonoJavaBridge.MethodId _values17967;
			public static global::android.widget.TextView.BufferType[] values()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<android.widget.TextView.BufferType>(@__env.CallStaticObjectMethod(android.widget.TextView.BufferType.staticClass, global::android.widget.TextView.BufferType._values17967)) as android.widget.TextView.BufferType[];
			}
			internal static global::MonoJavaBridge.MethodId _valueOf17968;
			public static global::android.widget.TextView.BufferType valueOf(java.lang.String arg0)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.widget.TextView.BufferType>(@__env.CallStaticObjectMethod(android.widget.TextView.BufferType.staticClass, global::android.widget.TextView.BufferType._valueOf17968, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.widget.TextView.BufferType;
			}
			internal static global::MonoJavaBridge.FieldId _EDITABLE17969;
			public static global::android.widget.TextView.BufferType EDITABLE
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.widget.TextView.BufferType>(@__env.GetStaticObjectField(global::android.widget.TextView.BufferType.staticClass, _EDITABLE17969)) as android.widget.TextView.BufferType;
				}
			}
			internal static global::MonoJavaBridge.FieldId _NORMAL17970;
			public static global::android.widget.TextView.BufferType NORMAL
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.widget.TextView.BufferType>(@__env.GetStaticObjectField(global::android.widget.TextView.BufferType.staticClass, _NORMAL17970)) as android.widget.TextView.BufferType;
				}
			}
			internal static global::MonoJavaBridge.FieldId _SPANNABLE17971;
			public static global::android.widget.TextView.BufferType SPANNABLE
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.widget.TextView.BufferType>(@__env.GetStaticObjectField(global::android.widget.TextView.BufferType.staticClass, _SPANNABLE17971)) as android.widget.TextView.BufferType;
				}
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.widget.TextView.BufferType.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/TextView$BufferType"));
				global::android.widget.TextView.BufferType._values17967 = @__env.GetStaticMethodIDNoThrow(global::android.widget.TextView.BufferType.staticClass, "values", "()[Landroid/widget/TextView/BufferType;");
				global::android.widget.TextView.BufferType._valueOf17968 = @__env.GetStaticMethodIDNoThrow(global::android.widget.TextView.BufferType.staticClass, "valueOf", "(Ljava/lang/String;)Landroid/widget/TextView$BufferType;");
				global::android.widget.TextView.BufferType._EDITABLE17969 = @__env.GetStaticFieldIDNoThrow(global::android.widget.TextView.BufferType.staticClass, "EDITABLE", "Landroid/widget/TextView$BufferType;");
				global::android.widget.TextView.BufferType._NORMAL17970 = @__env.GetStaticFieldIDNoThrow(global::android.widget.TextView.BufferType.staticClass, "NORMAL", "Landroid/widget/TextView$BufferType;");
				global::android.widget.TextView.BufferType._SPANNABLE17971 = @__env.GetStaticFieldIDNoThrow(global::android.widget.TextView.BufferType.staticClass, "SPANNABLE", "Landroid/widget/TextView$BufferType;");
			}
		}
		[global::MonoJavaBridge.JavaInterface(typeof(global::android.widget.TextView.OnEditorActionListener_))]
		public partial interface OnEditorActionListener  : global::MonoJavaBridge.IJavaObject 
		{
			bool onEditorAction(android.widget.TextView arg0, int arg1, android.view.KeyEvent arg2);
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.widget.TextView.OnEditorActionListener))]
		internal sealed partial class OnEditorActionListener_ : java.lang.Object, OnEditorActionListener
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static OnEditorActionListener_()
			{
				InitJNI();
			}
			internal OnEditorActionListener_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _onEditorAction17972;
			bool android.widget.TextView.OnEditorActionListener.onEditorAction(android.widget.TextView arg0, int arg1, android.view.KeyEvent arg2)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.TextView.OnEditorActionListener_._onEditorAction17972, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
				else
					return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.TextView.OnEditorActionListener_.staticClass, global::android.widget.TextView.OnEditorActionListener_._onEditorAction17972, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.widget.TextView.OnEditorActionListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/TextView$OnEditorActionListener"));
				global::android.widget.TextView.OnEditorActionListener_._onEditorAction17972 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.OnEditorActionListener_.staticClass, "onEditorAction", "(Landroid/widget/TextView;ILandroid/view/KeyEvent;)Z");
			}
		}

		public delegate bool OnEditorActionListenerDelegate(android.widget.TextView arg0, int arg1, android.view.KeyEvent arg2);

		internal partial class OnEditorActionListenerDelegateWrapper : java.lang.Object, OnEditorActionListener
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static OnEditorActionListenerDelegateWrapper()
			{
				InitJNI();
			}
			protected OnEditorActionListenerDelegateWrapper(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _OnEditorActionListenerDelegateWrapper17973;
			public OnEditorActionListenerDelegateWrapper() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.TextView.OnEditorActionListenerDelegateWrapper.staticClass, global::android.widget.TextView.OnEditorActionListenerDelegateWrapper._OnEditorActionListenerDelegateWrapper17973);
				Init(@__env, handle);
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.widget.TextView.OnEditorActionListenerDelegateWrapper.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/TextView_OnEditorActionListenerDelegateWrapper"));
				global::android.widget.TextView.OnEditorActionListenerDelegateWrapper._OnEditorActionListenerDelegateWrapper17973 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.OnEditorActionListenerDelegateWrapper.staticClass, "<init>", "()V");
			}
		}
		internal partial class OnEditorActionListenerDelegateWrapper
		{
			private OnEditorActionListenerDelegate myDelegate;
			public bool onEditorAction(android.widget.TextView arg0, int arg1, android.view.KeyEvent arg2)
			{
				return myDelegate(arg0, arg1, arg2);
			}
			public static implicit operator OnEditorActionListenerDelegateWrapper(OnEditorActionListenerDelegate d)
			{
				global::android.widget.TextView.OnEditorActionListenerDelegateWrapper ret = new global::android.widget.TextView.OnEditorActionListenerDelegateWrapper();
				ret.myDelegate = d;
				global::MonoJavaBridge.JavaBridge.SetGCHandle(global::MonoJavaBridge.JNIEnv.ThreadEnv, ret);
				return ret;
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
			internal static global::MonoJavaBridge.MethodId _toString17974;
			public override global::java.lang.String toString()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.TextView.SavedState._toString17974)) as java.lang.String;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.TextView.SavedState.staticClass, global::android.widget.TextView.SavedState._toString17974)) as java.lang.String;
			}
			internal static global::MonoJavaBridge.MethodId _writeToParcel17975;
			public override void writeToParcel(android.os.Parcel arg0, int arg1)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView.SavedState._writeToParcel17975, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.SavedState.staticClass, global::android.widget.TextView.SavedState._writeToParcel17975, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			internal static global::MonoJavaBridge.FieldId _CREATOR17976;
			public static global::android.os.Parcelable_Creator CREATOR
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.Parcelable_Creator>(@__env.GetStaticObjectField(global::android.widget.TextView.SavedState.staticClass, _CREATOR17976)) as android.os.Parcelable_Creator;
				}
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.widget.TextView.SavedState.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/TextView$SavedState"));
				global::android.widget.TextView.SavedState._toString17974 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.SavedState.staticClass, "toString", "()Ljava/lang/String;");
				global::android.widget.TextView.SavedState._writeToParcel17975 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.SavedState.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
				global::android.widget.TextView.SavedState._CREATOR17976 = @__env.GetStaticFieldIDNoThrow(global::android.widget.TextView.SavedState.staticClass, "CREATOR", "Landroid/os/Parcelable$Creator;");
			}
		}
		internal static global::MonoJavaBridge.MethodId _append17977;
		public virtual void append(java.lang.CharSequence arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._append17977, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._append17977, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public void append(string arg0)
		{
			append((global::java.lang.CharSequence)(global::java.lang.String)arg0);
		}
		internal static global::MonoJavaBridge.MethodId _append17978;
		public virtual void append(java.lang.CharSequence arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._append17978, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._append17978, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		public void append(string arg0, int arg1, int arg2)
		{
			append((global::java.lang.CharSequence)(global::java.lang.String)arg0, arg1, arg2);
		}
		internal static global::MonoJavaBridge.MethodId _length17979;
		public virtual int length()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.TextView._length17979);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._length17979);
		}
		internal static global::MonoJavaBridge.MethodId _debug17980;
		public virtual void debug(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._debug17980, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._debug17980, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setError17981;
		public virtual void setError(java.lang.CharSequence arg0, android.graphics.drawable.Drawable arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._setError17981, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._setError17981, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public void setError(string arg0, android.graphics.drawable.Drawable arg1)
		{
			setError((global::java.lang.CharSequence)(global::java.lang.String)arg0, arg1);
		}
		internal static global::MonoJavaBridge.MethodId _setError17982;
		public virtual void setError(java.lang.CharSequence arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._setError17982, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._setError17982, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public void setError(string arg0)
		{
			setError((global::java.lang.CharSequence)(global::java.lang.String)arg0);
		}
		internal static global::MonoJavaBridge.MethodId _setText17983;
		public virtual void setText(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._setText17983, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._setText17983, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setText17984;
		public virtual void setText(java.lang.CharSequence arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._setText17984, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._setText17984, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public void setText(string arg0)
		{
			setText((global::java.lang.CharSequence)(global::java.lang.String)arg0);
		}
		internal static global::MonoJavaBridge.MethodId _setText17985;
		public virtual void setText(java.lang.CharSequence arg0, android.widget.TextView.BufferType arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._setText17985, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._setText17985, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public void setText(string arg0, android.widget.TextView.BufferType arg1)
		{
			setText((global::java.lang.CharSequence)(global::java.lang.String)arg0, arg1);
		}
		internal static global::MonoJavaBridge.MethodId _setText17986;
		public virtual void setText(char[] arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._setText17986, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._setText17986, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setText17987;
		public virtual void setText(int arg0, android.widget.TextView.BufferType arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._setText17987, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._setText17987, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
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
		internal static global::MonoJavaBridge.MethodId _getText17988;
		public virtual global::java.lang.CharSequence getText()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.TextView._getText17988)) as java.lang.CharSequence;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._getText17988)) as java.lang.CharSequence;
		}
		public new global::android.text.Layout Layout
		{
			get
			{
				return getLayout();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getLayout17989;
		public virtual global::android.text.Layout getLayout()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.TextView._getLayout17989)) as android.text.Layout;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._getLayout17989)) as android.text.Layout;
		}
		internal static global::MonoJavaBridge.MethodId _onRestoreInstanceState17990;
		public virtual void onRestoreInstanceState(android.os.Parcelable arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._onRestoreInstanceState17990, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._onRestoreInstanceState17990, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onSaveInstanceState17991;
		public virtual global::android.os.Parcelable onSaveInstanceState()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.Parcelable>(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.TextView._onSaveInstanceState17991)) as android.os.Parcelable;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.Parcelable>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._onSaveInstanceState17991)) as android.os.Parcelable;
		}
		internal static global::MonoJavaBridge.MethodId _onKeyDown17992;
		public override bool onKeyDown(int arg0, android.view.KeyEvent arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.TextView._onKeyDown17992, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._onKeyDown17992, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _onKeyUp17993;
		public override bool onKeyUp(int arg0, android.view.KeyEvent arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.TextView._onKeyUp17993, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._onKeyUp17993, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _onKeyMultiple17994;
		public override bool onKeyMultiple(int arg0, int arg1, android.view.KeyEvent arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.TextView._onKeyMultiple17994, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._onKeyMultiple17994, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _onTouchEvent17995;
		public override bool onTouchEvent(android.view.MotionEvent arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.TextView._onTouchEvent17995, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._onTouchEvent17995, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onTrackballEvent17996;
		public override bool onTrackballEvent(android.view.MotionEvent arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.TextView._onTrackballEvent17996, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._onTrackballEvent17996, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onWindowFocusChanged17997;
		public override void onWindowFocusChanged(bool arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._onWindowFocusChanged17997, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._onWindowFocusChanged17997, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onAttachedToWindow17998;
		protected override void onAttachedToWindow()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._onAttachedToWindow17998);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._onAttachedToWindow17998);
		}
		internal static global::MonoJavaBridge.MethodId _onDetachedFromWindow17999;
		protected override void onDetachedFromWindow()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._onDetachedFromWindow17999);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._onDetachedFromWindow17999);
		}
		internal static global::MonoJavaBridge.MethodId _dispatchPopulateAccessibilityEvent18000;
		public override bool dispatchPopulateAccessibilityEvent(android.view.accessibility.AccessibilityEvent arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.TextView._dispatchPopulateAccessibilityEvent18000, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._dispatchPopulateAccessibilityEvent18000, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onCreateContextMenu18001;
		protected override void onCreateContextMenu(android.view.ContextMenu arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._onCreateContextMenu18001, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._onCreateContextMenu18001, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setGravity18002;
		public virtual void setGravity(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._setGravity18002, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._setGravity18002, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _performLongClick18003;
		public override bool performLongClick()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.TextView._performLongClick18003);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._performLongClick18003);
		}
		internal static global::MonoJavaBridge.MethodId _onFocusChanged18004;
		protected override void onFocusChanged(bool arg0, int arg1, android.graphics.Rect arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._onFocusChanged18004, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._onFocusChanged18004, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _onStartTemporaryDetach18005;
		public override void onStartTemporaryDetach()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._onStartTemporaryDetach18005);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._onStartTemporaryDetach18005);
		}
		internal static global::MonoJavaBridge.MethodId _onFinishTemporaryDetach18006;
		public override void onFinishTemporaryDetach()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._onFinishTemporaryDetach18006);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._onFinishTemporaryDetach18006);
		}
		internal static global::MonoJavaBridge.MethodId _onKeyShortcut18007;
		public override bool onKeyShortcut(int arg0, android.view.KeyEvent arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.TextView._onKeyShortcut18007, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._onKeyShortcut18007, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _onCheckIsTextEditor18008;
		public override bool onCheckIsTextEditor()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.TextView._onCheckIsTextEditor18008);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._onCheckIsTextEditor18008);
		}
		internal static global::MonoJavaBridge.MethodId _onCreateInputConnection18009;
		public override global::android.view.inputmethod.InputConnection onCreateInputConnection(android.view.inputmethod.EditorInfo arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.inputmethod.InputConnection>(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.TextView._onCreateInputConnection18009, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.inputmethod.InputConnection;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.inputmethod.InputConnection>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._onCreateInputConnection18009, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.inputmethod.InputConnection;
		}
		internal static global::MonoJavaBridge.MethodId _cancelLongPress18010;
		public override void cancelLongPress()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._cancelLongPress18010);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._cancelLongPress18010);
		}
		internal static global::MonoJavaBridge.MethodId _getFocusedRect18011;
		public override void getFocusedRect(android.graphics.Rect arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._getFocusedRect18011, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._getFocusedRect18011, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _computeScroll18012;
		public override void computeScroll()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._computeScroll18012);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._computeScroll18012);
		}
		protected new float LeftFadingEdgeStrength
		{
			get
			{
				return getLeftFadingEdgeStrength();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getLeftFadingEdgeStrength18013;
		protected override float getLeftFadingEdgeStrength()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.widget.TextView._getLeftFadingEdgeStrength18013);
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._getLeftFadingEdgeStrength18013);
		}
		protected new float RightFadingEdgeStrength
		{
			get
			{
				return getRightFadingEdgeStrength();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getRightFadingEdgeStrength18014;
		protected override float getRightFadingEdgeStrength()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.widget.TextView._getRightFadingEdgeStrength18014);
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._getRightFadingEdgeStrength18014);
		}
		internal static global::MonoJavaBridge.MethodId _computeHorizontalScrollRange18015;
		protected override int computeHorizontalScrollRange()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.TextView._computeHorizontalScrollRange18015);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._computeHorizontalScrollRange18015);
		}
		internal static global::MonoJavaBridge.MethodId _computeVerticalScrollRange18016;
		protected override int computeVerticalScrollRange()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.TextView._computeVerticalScrollRange18016);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._computeVerticalScrollRange18016);
		}
		internal static global::MonoJavaBridge.MethodId _computeVerticalScrollExtent18017;
		protected override int computeVerticalScrollExtent()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.TextView._computeVerticalScrollExtent18017);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._computeVerticalScrollExtent18017);
		}
		internal static global::MonoJavaBridge.MethodId _onDraw18018;
		protected override void onDraw(android.graphics.Canvas arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._onDraw18018, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._onDraw18018, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isPaddingOffsetRequired18019;
		protected override bool isPaddingOffsetRequired()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.TextView._isPaddingOffsetRequired18019);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._isPaddingOffsetRequired18019);
		}
		protected new int LeftPaddingOffset
		{
			get
			{
				return getLeftPaddingOffset();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getLeftPaddingOffset18020;
		protected override int getLeftPaddingOffset()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.TextView._getLeftPaddingOffset18020);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._getLeftPaddingOffset18020);
		}
		protected new int RightPaddingOffset
		{
			get
			{
				return getRightPaddingOffset();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getRightPaddingOffset18021;
		protected override int getRightPaddingOffset()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.TextView._getRightPaddingOffset18021);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._getRightPaddingOffset18021);
		}
		protected new int TopPaddingOffset
		{
			get
			{
				return getTopPaddingOffset();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getTopPaddingOffset18022;
		protected override int getTopPaddingOffset()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.TextView._getTopPaddingOffset18022);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._getTopPaddingOffset18022);
		}
		protected new int BottomPaddingOffset
		{
			get
			{
				return getBottomPaddingOffset();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getBottomPaddingOffset18023;
		protected override int getBottomPaddingOffset()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.TextView._getBottomPaddingOffset18023);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._getBottomPaddingOffset18023);
		}
		internal static global::MonoJavaBridge.MethodId _invalidateDrawable18024;
		public override void invalidateDrawable(android.graphics.drawable.Drawable arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._invalidateDrawable18024, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._invalidateDrawable18024, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _verifyDrawable18025;
		protected override bool verifyDrawable(android.graphics.drawable.Drawable arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.TextView._verifyDrawable18025, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._verifyDrawable18025, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _drawableStateChanged18026;
		protected override void drawableStateChanged()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._drawableStateChanged18026);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._drawableStateChanged18026);
		}
		internal static global::MonoJavaBridge.MethodId _setPadding18027;
		public override void setPadding(int arg0, int arg1, int arg2, int arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._setPadding18027, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._setPadding18027, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		public new bool Selected
		{
			set
			{
				setSelected(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setSelected18028;
		public override void setSelected(bool arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._setSelected18028, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._setSelected18028, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int Baseline
		{
			get
			{
				return getBaseline();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getBaseline18029;
		public override int getBaseline()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.TextView._getBaseline18029);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._getBaseline18029);
		}
		internal static global::MonoJavaBridge.MethodId _onMeasure18030;
		protected override void onMeasure(int arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._onMeasure18030, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._onMeasure18030, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setTypeface18031;
		public virtual void setTypeface(android.graphics.Typeface arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._setTypeface18031, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._setTypeface18031, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setTypeface18032;
		public virtual void setTypeface(android.graphics.Typeface arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._setTypeface18032, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._setTypeface18032, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		protected new bool DefaultEditable
		{
			get
			{
				return getDefaultEditable();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getDefaultEditable18033;
		protected virtual bool getDefaultEditable()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.TextView._getDefaultEditable18033);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._getDefaultEditable18033);
		}
		protected new global::android.text.method.MovementMethod DefaultMovementMethod
		{
			get
			{
				return getDefaultMovementMethod();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getDefaultMovementMethod18034;
		protected virtual global::android.text.method.MovementMethod getDefaultMovementMethod()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.text.method.MovementMethod>(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.TextView._getDefaultMovementMethod18034)) as android.text.method.MovementMethod;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.text.method.MovementMethod>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._getDefaultMovementMethod18034)) as android.text.method.MovementMethod;
		}
		public new global::android.text.Editable EditableText
		{
			get
			{
				return getEditableText();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getEditableText18035;
		public virtual global::android.text.Editable getEditableText()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.text.Editable>(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.TextView._getEditableText18035)) as android.text.Editable;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.text.Editable>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._getEditableText18035)) as android.text.Editable;
		}
		public new int LineHeight
		{
			get
			{
				return getLineHeight();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getLineHeight18036;
		public virtual int getLineHeight()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.TextView._getLineHeight18036);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._getLineHeight18036);
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
		internal static global::MonoJavaBridge.MethodId _getKeyListener18037;
		public virtual global::android.text.method.KeyListener getKeyListener()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.text.method.KeyListener>(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.TextView._getKeyListener18037)) as android.text.method.KeyListener;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.text.method.KeyListener>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._getKeyListener18037)) as android.text.method.KeyListener;
		}
		internal static global::MonoJavaBridge.MethodId _setKeyListener18038;
		public virtual void setKeyListener(android.text.method.KeyListener arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._setKeyListener18038, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._setKeyListener18038, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getMovementMethod18039;
		public virtual global::android.text.method.MovementMethod getMovementMethod()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.text.method.MovementMethod>(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.TextView._getMovementMethod18039)) as android.text.method.MovementMethod;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.text.method.MovementMethod>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._getMovementMethod18039)) as android.text.method.MovementMethod;
		}
		internal static global::MonoJavaBridge.MethodId _setMovementMethod18040;
		public virtual void setMovementMethod(android.text.method.MovementMethod arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._setMovementMethod18040, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._setMovementMethod18040, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getTransformationMethod18041;
		public virtual global::android.text.method.TransformationMethod getTransformationMethod()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.text.method.TransformationMethod>(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.TextView._getTransformationMethod18041)) as android.text.method.TransformationMethod;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.text.method.TransformationMethod>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._getTransformationMethod18041)) as android.text.method.TransformationMethod;
		}
		internal static global::MonoJavaBridge.MethodId _setTransformationMethod18042;
		public virtual void setTransformationMethod(android.text.method.TransformationMethod arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._setTransformationMethod18042, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._setTransformationMethod18042, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int CompoundPaddingTop
		{
			get
			{
				return getCompoundPaddingTop();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getCompoundPaddingTop18043;
		public virtual int getCompoundPaddingTop()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.TextView._getCompoundPaddingTop18043);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._getCompoundPaddingTop18043);
		}
		public new int CompoundPaddingBottom
		{
			get
			{
				return getCompoundPaddingBottom();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getCompoundPaddingBottom18044;
		public virtual int getCompoundPaddingBottom()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.TextView._getCompoundPaddingBottom18044);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._getCompoundPaddingBottom18044);
		}
		public new int CompoundPaddingLeft
		{
			get
			{
				return getCompoundPaddingLeft();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getCompoundPaddingLeft18045;
		public virtual int getCompoundPaddingLeft()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.TextView._getCompoundPaddingLeft18045);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._getCompoundPaddingLeft18045);
		}
		public new int CompoundPaddingRight
		{
			get
			{
				return getCompoundPaddingRight();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getCompoundPaddingRight18046;
		public virtual int getCompoundPaddingRight()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.TextView._getCompoundPaddingRight18046);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._getCompoundPaddingRight18046);
		}
		public new int ExtendedPaddingTop
		{
			get
			{
				return getExtendedPaddingTop();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getExtendedPaddingTop18047;
		public virtual int getExtendedPaddingTop()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.TextView._getExtendedPaddingTop18047);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._getExtendedPaddingTop18047);
		}
		public new int ExtendedPaddingBottom
		{
			get
			{
				return getExtendedPaddingBottom();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getExtendedPaddingBottom18048;
		public virtual int getExtendedPaddingBottom()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.TextView._getExtendedPaddingBottom18048);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._getExtendedPaddingBottom18048);
		}
		public new int TotalPaddingLeft
		{
			get
			{
				return getTotalPaddingLeft();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getTotalPaddingLeft18049;
		public virtual int getTotalPaddingLeft()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.TextView._getTotalPaddingLeft18049);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._getTotalPaddingLeft18049);
		}
		public new int TotalPaddingRight
		{
			get
			{
				return getTotalPaddingRight();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getTotalPaddingRight18050;
		public virtual int getTotalPaddingRight()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.TextView._getTotalPaddingRight18050);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._getTotalPaddingRight18050);
		}
		public new int TotalPaddingTop
		{
			get
			{
				return getTotalPaddingTop();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getTotalPaddingTop18051;
		public virtual int getTotalPaddingTop()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.TextView._getTotalPaddingTop18051);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._getTotalPaddingTop18051);
		}
		public new int TotalPaddingBottom
		{
			get
			{
				return getTotalPaddingBottom();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getTotalPaddingBottom18052;
		public virtual int getTotalPaddingBottom()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.TextView._getTotalPaddingBottom18052);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._getTotalPaddingBottom18052);
		}
		internal static global::MonoJavaBridge.MethodId _setCompoundDrawables18053;
		public virtual void setCompoundDrawables(android.graphics.drawable.Drawable arg0, android.graphics.drawable.Drawable arg1, android.graphics.drawable.Drawable arg2, android.graphics.drawable.Drawable arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._setCompoundDrawables18053, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._setCompoundDrawables18053, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _setCompoundDrawablesWithIntrinsicBounds18054;
		public virtual void setCompoundDrawablesWithIntrinsicBounds(android.graphics.drawable.Drawable arg0, android.graphics.drawable.Drawable arg1, android.graphics.drawable.Drawable arg2, android.graphics.drawable.Drawable arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._setCompoundDrawablesWithIntrinsicBounds18054, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._setCompoundDrawablesWithIntrinsicBounds18054, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _setCompoundDrawablesWithIntrinsicBounds18055;
		public virtual void setCompoundDrawablesWithIntrinsicBounds(int arg0, int arg1, int arg2, int arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._setCompoundDrawablesWithIntrinsicBounds18055, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._setCompoundDrawablesWithIntrinsicBounds18055, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		public new global::android.graphics.drawable.Drawable[] CompoundDrawables
		{
			get
			{
				return getCompoundDrawables();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getCompoundDrawables18056;
		public virtual global::android.graphics.drawable.Drawable[] getCompoundDrawables()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<android.graphics.drawable.Drawable>(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.TextView._getCompoundDrawables18056)) as android.graphics.drawable.Drawable[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<android.graphics.drawable.Drawable>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._getCompoundDrawables18056)) as android.graphics.drawable.Drawable[];
		}
		internal static global::MonoJavaBridge.MethodId _setCompoundDrawablePadding18057;
		public virtual void setCompoundDrawablePadding(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._setCompoundDrawablePadding18057, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._setCompoundDrawablePadding18057, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getCompoundDrawablePadding18058;
		public virtual int getCompoundDrawablePadding()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.TextView._getCompoundDrawablePadding18058);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._getCompoundDrawablePadding18058);
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
		internal static global::MonoJavaBridge.MethodId _getAutoLinkMask18059;
		public virtual int getAutoLinkMask()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.TextView._getAutoLinkMask18059);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._getAutoLinkMask18059);
		}
		internal static global::MonoJavaBridge.MethodId _setTextAppearance18060;
		public virtual void setTextAppearance(android.content.Context arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._setTextAppearance18060, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._setTextAppearance18060, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
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
		internal static global::MonoJavaBridge.MethodId _getTextSize18061;
		public virtual float getTextSize()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.widget.TextView._getTextSize18061);
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._getTextSize18061);
		}
		internal static global::MonoJavaBridge.MethodId _setTextSize18062;
		public virtual void setTextSize(int arg0, float arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._setTextSize18062, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._setTextSize18062, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setTextSize18063;
		public virtual void setTextSize(float arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._setTextSize18063, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._setTextSize18063, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getTextScaleX18064;
		public virtual float getTextScaleX()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.widget.TextView._getTextScaleX18064);
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._getTextScaleX18064);
		}
		internal static global::MonoJavaBridge.MethodId _setTextScaleX18065;
		public virtual void setTextScaleX(float arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._setTextScaleX18065, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._setTextScaleX18065, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getTypeface18066;
		public virtual global::android.graphics.Typeface getTypeface()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.TextView._getTypeface18066)) as android.graphics.Typeface;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._getTypeface18066)) as android.graphics.Typeface;
		}
		internal static global::MonoJavaBridge.MethodId _setTextColor18067;
		public virtual void setTextColor(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._setTextColor18067, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._setTextColor18067, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setTextColor18068;
		public virtual void setTextColor(android.content.res.ColorStateList arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._setTextColor18068, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._setTextColor18068, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::android.content.res.ColorStateList TextColors
		{
			get
			{
				return getTextColors();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getTextColors18069;
		public virtual global::android.content.res.ColorStateList getTextColors()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.TextView._getTextColors18069)) as android.content.res.ColorStateList;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._getTextColors18069)) as android.content.res.ColorStateList;
		}
		internal static global::MonoJavaBridge.MethodId _getTextColors18070;
		public static global::android.content.res.ColorStateList getTextColors(android.content.Context arg0, android.content.res.TypedArray arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.widget.TextView.staticClass, global::android.widget.TextView._getTextColors18070, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.res.ColorStateList;
		}
		public new int CurrentTextColor
		{
			get
			{
				return getCurrentTextColor();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getCurrentTextColor18071;
		public virtual int getCurrentTextColor()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.TextView._getCurrentTextColor18071);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._getCurrentTextColor18071);
		}
		public new int HighlightColor
		{
			set
			{
				setHighlightColor(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setHighlightColor18072;
		public virtual void setHighlightColor(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._setHighlightColor18072, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._setHighlightColor18072, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setShadowLayer18073;
		public virtual void setShadowLayer(float arg0, float arg1, float arg2, int arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._setShadowLayer18073, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._setShadowLayer18073, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		public new global::android.text.TextPaint Paint
		{
			get
			{
				return getPaint();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getPaint18074;
		public virtual global::android.text.TextPaint getPaint()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.TextView._getPaint18074)) as android.text.TextPaint;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._getPaint18074)) as android.text.TextPaint;
		}
		internal static global::MonoJavaBridge.MethodId _setAutoLinkMask18075;
		public virtual void setAutoLinkMask(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._setAutoLinkMask18075, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._setAutoLinkMask18075, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setLinksClickable18076;
		public virtual void setLinksClickable(bool arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._setLinksClickable18076, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._setLinksClickable18076, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getLinksClickable18077;
		public virtual bool getLinksClickable()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.TextView._getLinksClickable18077);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._getLinksClickable18077);
		}
		public new global::android.text.style.URLSpan[] Urls
		{
			get
			{
				return getUrls();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getUrls18078;
		public virtual global::android.text.style.URLSpan[] getUrls()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<android.text.style.URLSpan>(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.TextView._getUrls18078)) as android.text.style.URLSpan[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<android.text.style.URLSpan>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._getUrls18078)) as android.text.style.URLSpan[];
		}
		internal static global::MonoJavaBridge.MethodId _setHintTextColor18079;
		public virtual void setHintTextColor(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._setHintTextColor18079, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._setHintTextColor18079, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setHintTextColor18080;
		public virtual void setHintTextColor(android.content.res.ColorStateList arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._setHintTextColor18080, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._setHintTextColor18080, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::android.content.res.ColorStateList HintTextColors
		{
			get
			{
				return getHintTextColors();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getHintTextColors18081;
		public virtual global::android.content.res.ColorStateList getHintTextColors()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.TextView._getHintTextColors18081)) as android.content.res.ColorStateList;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._getHintTextColors18081)) as android.content.res.ColorStateList;
		}
		public new int CurrentHintTextColor
		{
			get
			{
				return getCurrentHintTextColor();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getCurrentHintTextColor18082;
		public virtual int getCurrentHintTextColor()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.TextView._getCurrentHintTextColor18082);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._getCurrentHintTextColor18082);
		}
		internal static global::MonoJavaBridge.MethodId _setLinkTextColor18083;
		public virtual void setLinkTextColor(android.content.res.ColorStateList arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._setLinkTextColor18083, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._setLinkTextColor18083, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setLinkTextColor18084;
		public virtual void setLinkTextColor(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._setLinkTextColor18084, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._setLinkTextColor18084, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::android.content.res.ColorStateList LinkTextColors
		{
			get
			{
				return getLinkTextColors();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getLinkTextColors18085;
		public virtual global::android.content.res.ColorStateList getLinkTextColors()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.TextView._getLinkTextColors18085)) as android.content.res.ColorStateList;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._getLinkTextColors18085)) as android.content.res.ColorStateList;
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
		internal static global::MonoJavaBridge.MethodId _getGravity18086;
		public virtual int getGravity()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.TextView._getGravity18086);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._getGravity18086);
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
		internal static global::MonoJavaBridge.MethodId _getPaintFlags18087;
		public virtual int getPaintFlags()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.TextView._getPaintFlags18087);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._getPaintFlags18087);
		}
		internal static global::MonoJavaBridge.MethodId _setPaintFlags18088;
		public virtual void setPaintFlags(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._setPaintFlags18088, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._setPaintFlags18088, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new bool HorizontallyScrolling
		{
			set
			{
				setHorizontallyScrolling(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setHorizontallyScrolling18089;
		public virtual void setHorizontallyScrolling(bool arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._setHorizontallyScrolling18089, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._setHorizontallyScrolling18089, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int MinLines
		{
			set
			{
				setMinLines(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setMinLines18090;
		public virtual void setMinLines(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._setMinLines18090, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._setMinLines18090, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int MinHeight
		{
			set
			{
				setMinHeight(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setMinHeight18091;
		public virtual void setMinHeight(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._setMinHeight18091, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._setMinHeight18091, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int MaxLines
		{
			set
			{
				setMaxLines(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setMaxLines18092;
		public virtual void setMaxLines(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._setMaxLines18092, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._setMaxLines18092, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int MaxHeight
		{
			set
			{
				setMaxHeight(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setMaxHeight18093;
		public virtual void setMaxHeight(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._setMaxHeight18093, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._setMaxHeight18093, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int Lines
		{
			set
			{
				setLines(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setLines18094;
		public virtual void setLines(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._setLines18094, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._setLines18094, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int Height
		{
			set
			{
				setHeight(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setHeight18095;
		public virtual void setHeight(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._setHeight18095, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._setHeight18095, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int MinEms
		{
			set
			{
				setMinEms(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setMinEms18096;
		public virtual void setMinEms(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._setMinEms18096, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._setMinEms18096, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int MinWidth
		{
			set
			{
				setMinWidth(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setMinWidth18097;
		public virtual void setMinWidth(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._setMinWidth18097, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._setMinWidth18097, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int MaxEms
		{
			set
			{
				setMaxEms(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setMaxEms18098;
		public virtual void setMaxEms(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._setMaxEms18098, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._setMaxEms18098, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int MaxWidth
		{
			set
			{
				setMaxWidth(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setMaxWidth18099;
		public virtual void setMaxWidth(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._setMaxWidth18099, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._setMaxWidth18099, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int Ems
		{
			set
			{
				setEms(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setEms18100;
		public virtual void setEms(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._setEms18100, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._setEms18100, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int Width
		{
			set
			{
				setWidth(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setWidth18101;
		public virtual void setWidth(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._setWidth18101, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._setWidth18101, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setLineSpacing18102;
		public virtual void setLineSpacing(float arg0, float arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._setLineSpacing18102, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._setLineSpacing18102, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setFreezesText18103;
		public virtual void setFreezesText(bool arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._setFreezesText18103, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._setFreezesText18103, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getFreezesText18104;
		public virtual bool getFreezesText()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.TextView._getFreezesText18104);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._getFreezesText18104);
		}
		public new global::android.text.Editable_Factory EditableFactory
		{
			set
			{
				setEditableFactory(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setEditableFactory18105;
		public virtual void setEditableFactory(android.text.Editable_Factory arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._setEditableFactory18105, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._setEditableFactory18105, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::android.text.Spannable_Factory SpannableFactory
		{
			set
			{
				setSpannableFactory(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setSpannableFactory18106;
		public virtual void setSpannableFactory(android.text.Spannable_Factory arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._setSpannableFactory18106, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._setSpannableFactory18106, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setTextKeepState18107;
		public virtual void setTextKeepState(java.lang.CharSequence arg0, android.widget.TextView.BufferType arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._setTextKeepState18107, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._setTextKeepState18107, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public void setTextKeepState(string arg0, android.widget.TextView.BufferType arg1)
		{
			setTextKeepState((global::java.lang.CharSequence)(global::java.lang.String)arg0, arg1);
		}
		public new global::java.lang.CharSequence TextKeepState
		{
			set
			{
				setTextKeepState(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setTextKeepState18108;
		public virtual void setTextKeepState(java.lang.CharSequence arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._setTextKeepState18108, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._setTextKeepState18108, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public void setTextKeepState(string arg0)
		{
			setTextKeepState((global::java.lang.CharSequence)(global::java.lang.String)arg0);
		}
		internal static global::MonoJavaBridge.MethodId _setHint18109;
		public virtual void setHint(java.lang.CharSequence arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._setHint18109, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._setHint18109, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public void setHint(string arg0)
		{
			setHint((global::java.lang.CharSequence)(global::java.lang.String)arg0);
		}
		internal static global::MonoJavaBridge.MethodId _setHint18110;
		public virtual void setHint(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._setHint18110, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._setHint18110, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getHint18111;
		public virtual global::java.lang.CharSequence getHint()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.TextView._getHint18111)) as java.lang.CharSequence;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._getHint18111)) as java.lang.CharSequence;
		}
		internal static global::MonoJavaBridge.MethodId _setInputType18112;
		public virtual void setInputType(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._setInputType18112, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._setInputType18112, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int RawInputType
		{
			set
			{
				setRawInputType(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setRawInputType18113;
		public virtual void setRawInputType(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._setRawInputType18113, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._setRawInputType18113, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getInputType18114;
		public virtual int getInputType()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.TextView._getInputType18114);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._getInputType18114);
		}
		internal static global::MonoJavaBridge.MethodId _setImeOptions18115;
		public virtual void setImeOptions(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._setImeOptions18115, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._setImeOptions18115, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getImeOptions18116;
		public virtual int getImeOptions()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.TextView._getImeOptions18116);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._getImeOptions18116);
		}
		internal static global::MonoJavaBridge.MethodId _setImeActionLabel18117;
		public virtual void setImeActionLabel(java.lang.CharSequence arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._setImeActionLabel18117, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._setImeActionLabel18117, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
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
		internal static global::MonoJavaBridge.MethodId _getImeActionLabel18118;
		public virtual global::java.lang.CharSequence getImeActionLabel()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.TextView._getImeActionLabel18118)) as java.lang.CharSequence;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._getImeActionLabel18118)) as java.lang.CharSequence;
		}
		public new int ImeActionId
		{
			get
			{
				return getImeActionId();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getImeActionId18119;
		public virtual int getImeActionId()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.TextView._getImeActionId18119);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._getImeActionId18119);
		}
		internal static global::MonoJavaBridge.MethodId _setOnEditorActionListener18120;
		public virtual void setOnEditorActionListener(android.widget.TextView.OnEditorActionListener arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._setOnEditorActionListener18120, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._setOnEditorActionListener18120, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public void setOnEditorActionListener(global::android.widget.TextView.OnEditorActionListenerDelegate arg0)
		{
			setOnEditorActionListener((global::android.widget.TextView.OnEditorActionListenerDelegateWrapper)arg0);
		}
		internal static global::MonoJavaBridge.MethodId _onEditorAction18121;
		public virtual void onEditorAction(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._onEditorAction18121, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._onEditorAction18121, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setPrivateImeOptions18122;
		public virtual void setPrivateImeOptions(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._setPrivateImeOptions18122, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._setPrivateImeOptions18122, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getPrivateImeOptions18123;
		public virtual global::java.lang.String getPrivateImeOptions()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.TextView._getPrivateImeOptions18123)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._getPrivateImeOptions18123)) as java.lang.String;
		}
		public new int InputExtras
		{
			set
			{
				setInputExtras(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setInputExtras18124;
		public virtual void setInputExtras(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._setInputExtras18124, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._setInputExtras18124, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getInputExtras18125;
		public virtual global::android.os.Bundle getInputExtras(bool arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.os.Bundle>(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.TextView._getInputExtras18125, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.os.Bundle;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.os.Bundle>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._getInputExtras18125, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.os.Bundle;
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
		internal static global::MonoJavaBridge.MethodId _getError18126;
		public virtual global::java.lang.CharSequence getError()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.TextView._getError18126)) as java.lang.CharSequence;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._getError18126)) as java.lang.CharSequence;
		}
		internal static global::MonoJavaBridge.MethodId _setFrame18127;
		protected virtual bool setFrame(int arg0, int arg1, int arg2, int arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.TextView._setFrame18127, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._setFrame18127, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _setFilters18128;
		public virtual void setFilters(android.text.InputFilter[] arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._setFilters18128, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._setFilters18128, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getFilters18129;
		public virtual global::android.text.InputFilter[] getFilters()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<android.text.InputFilter>(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.TextView._getFilters18129)) as android.text.InputFilter[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<android.text.InputFilter>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._getFilters18129)) as android.text.InputFilter[];
		}
		internal static global::MonoJavaBridge.MethodId _onPreDraw18130;
		public virtual bool onPreDraw()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.TextView._onPreDraw18130);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._onPreDraw18130);
		}
		public new int LineCount
		{
			get
			{
				return getLineCount();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getLineCount18131;
		public virtual int getLineCount()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.TextView._getLineCount18131);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._getLineCount18131);
		}
		internal static global::MonoJavaBridge.MethodId _getLineBounds18132;
		public virtual int getLineBounds(int arg0, android.graphics.Rect arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.TextView._getLineBounds18132, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._getLineBounds18132, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _extractText18133;
		public virtual bool extractText(android.view.inputmethod.ExtractedTextRequest arg0, android.view.inputmethod.ExtractedText arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.TextView._extractText18133, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._extractText18133, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public new global::android.view.inputmethod.ExtractedText ExtractedText
		{
			set
			{
				setExtractedText(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setExtractedText18134;
		public virtual void setExtractedText(android.view.inputmethod.ExtractedText arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._setExtractedText18134, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._setExtractedText18134, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onCommitCompletion18135;
		public virtual void onCommitCompletion(android.view.inputmethod.CompletionInfo arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._onCommitCompletion18135, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._onCommitCompletion18135, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _beginBatchEdit18136;
		public virtual void beginBatchEdit()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._beginBatchEdit18136);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._beginBatchEdit18136);
		}
		internal static global::MonoJavaBridge.MethodId _endBatchEdit18137;
		public virtual void endBatchEdit()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._endBatchEdit18137);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._endBatchEdit18137);
		}
		internal static global::MonoJavaBridge.MethodId _onBeginBatchEdit18138;
		public virtual void onBeginBatchEdit()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._onBeginBatchEdit18138);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._onBeginBatchEdit18138);
		}
		internal static global::MonoJavaBridge.MethodId _onEndBatchEdit18139;
		public virtual void onEndBatchEdit()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._onEndBatchEdit18139);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._onEndBatchEdit18139);
		}
		internal static global::MonoJavaBridge.MethodId _onPrivateIMECommand18140;
		public virtual bool onPrivateIMECommand(java.lang.String arg0, android.os.Bundle arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.TextView._onPrivateIMECommand18140, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._onPrivateIMECommand18140, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public new bool IncludeFontPadding
		{
			set
			{
				setIncludeFontPadding(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setIncludeFontPadding18141;
		public virtual void setIncludeFontPadding(bool arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._setIncludeFontPadding18141, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._setIncludeFontPadding18141, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _bringPointIntoView18142;
		public virtual bool bringPointIntoView(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.TextView._bringPointIntoView18142, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._bringPointIntoView18142, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _moveCursorToVisibleOffset18143;
		public virtual bool moveCursorToVisibleOffset()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.TextView._moveCursorToVisibleOffset18143);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._moveCursorToVisibleOffset18143);
		}
		public new int SelectionStart
		{
			get
			{
				return getSelectionStart();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getSelectionStart18144;
		public virtual int getSelectionStart()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.TextView._getSelectionStart18144);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._getSelectionStart18144);
		}
		public new int SelectionEnd
		{
			get
			{
				return getSelectionEnd();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getSelectionEnd18145;
		public virtual int getSelectionEnd()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.TextView._getSelectionEnd18145);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._getSelectionEnd18145);
		}
		internal static global::MonoJavaBridge.MethodId _hasSelection18146;
		public virtual bool hasSelection()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.TextView._hasSelection18146);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._hasSelection18146);
		}
		internal static global::MonoJavaBridge.MethodId _setSingleLine18147;
		public virtual void setSingleLine()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._setSingleLine18147);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._setSingleLine18147);
		}
		public new bool SingleLine
		{
			set
			{
				setSingleLine(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setSingleLine18148;
		public virtual void setSingleLine(bool arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._setSingleLine18148, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._setSingleLine18148, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setEllipsize18149;
		public virtual void setEllipsize(android.text.TextUtils.TruncateAt arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._setEllipsize18149, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._setEllipsize18149, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int MarqueeRepeatLimit
		{
			set
			{
				setMarqueeRepeatLimit(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setMarqueeRepeatLimit18150;
		public virtual void setMarqueeRepeatLimit(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._setMarqueeRepeatLimit18150, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._setMarqueeRepeatLimit18150, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getEllipsize18151;
		public virtual global::android.text.TextUtils.TruncateAt getEllipsize()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.text.TextUtils.TruncateAt>(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.TextView._getEllipsize18151)) as android.text.TextUtils.TruncateAt;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.text.TextUtils.TruncateAt>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._getEllipsize18151)) as android.text.TextUtils.TruncateAt;
		}
		public new bool SelectAllOnFocus
		{
			set
			{
				setSelectAllOnFocus(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setSelectAllOnFocus18152;
		public virtual void setSelectAllOnFocus(bool arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._setSelectAllOnFocus18152, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._setSelectAllOnFocus18152, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new bool CursorVisible
		{
			set
			{
				setCursorVisible(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setCursorVisible18153;
		public virtual void setCursorVisible(bool arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._setCursorVisible18153, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._setCursorVisible18153, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onTextChanged18154;
		protected virtual void onTextChanged(java.lang.CharSequence arg0, int arg1, int arg2, int arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._onTextChanged18154, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._onTextChanged18154, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		protected void onTextChanged(string arg0, int arg1, int arg2, int arg3)
		{
			onTextChanged((global::java.lang.CharSequence)(global::java.lang.String)arg0, arg1, arg2, arg3);
		}
		internal static global::MonoJavaBridge.MethodId _onSelectionChanged18155;
		protected virtual void onSelectionChanged(int arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._onSelectionChanged18155, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._onSelectionChanged18155, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _addTextChangedListener18156;
		public virtual void addTextChangedListener(android.text.TextWatcher arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._addTextChangedListener18156, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._addTextChangedListener18156, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _removeTextChangedListener18157;
		public virtual void removeTextChangedListener(android.text.TextWatcher arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._removeTextChangedListener18157, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._removeTextChangedListener18157, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _clearComposingText18158;
		public virtual void clearComposingText()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._clearComposingText18158);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._clearComposingText18158);
		}
		internal static global::MonoJavaBridge.MethodId _didTouchFocusSelect18159;
		public virtual bool didTouchFocusSelect()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.TextView._didTouchFocusSelect18159);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._didTouchFocusSelect18159);
		}
		public new global::android.widget.Scroller Scroller
		{
			set
			{
				setScroller(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setScroller18160;
		public virtual void setScroller(android.widget.Scroller arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._setScroller18160, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._setScroller18160, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getTextColor18161;
		public static int getTextColor(android.content.Context arg0, android.content.res.TypedArray arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.widget.TextView.staticClass, global::android.widget.TextView._getTextColor18161, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _isInputMethodTarget18162;
		public virtual bool isInputMethodTarget()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.TextView._isInputMethodTarget18162);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._isInputMethodTarget18162);
		}
		internal static global::MonoJavaBridge.MethodId _onTextContextMenuItem18163;
		public virtual bool onTextContextMenuItem(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.TextView._onTextContextMenuItem18163, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._onTextContextMenuItem18163, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _TextView18164;
		public TextView(android.content.Context arg0, android.util.AttributeSet arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.TextView.staticClass, global::android.widget.TextView._TextView18164, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _TextView18165;
		public TextView(android.content.Context arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.TextView.staticClass, global::android.widget.TextView._TextView18165, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _TextView18166;
		public TextView(android.content.Context arg0, android.util.AttributeSet arg1, int arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.TextView.staticClass, global::android.widget.TextView._TextView18166, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.widget.TextView.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/TextView"));
			global::android.widget.TextView._append17977 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "append", "(Ljava/lang/CharSequence;)V");
			global::android.widget.TextView._append17978 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "append", "(Ljava/lang/CharSequence;II)V");
			global::android.widget.TextView._length17979 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "length", "()I");
			global::android.widget.TextView._debug17980 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "debug", "(I)V");
			global::android.widget.TextView._setError17981 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "setError", "(Ljava/lang/CharSequence;Landroid/graphics/drawable/Drawable;)V");
			global::android.widget.TextView._setError17982 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "setError", "(Ljava/lang/CharSequence;)V");
			global::android.widget.TextView._setText17983 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "setText", "(I)V");
			global::android.widget.TextView._setText17984 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "setText", "(Ljava/lang/CharSequence;)V");
			global::android.widget.TextView._setText17985 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "setText", "(Ljava/lang/CharSequence;Landroid/widget/TextView$BufferType;)V");
			global::android.widget.TextView._setText17986 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "setText", "([CII)V");
			global::android.widget.TextView._setText17987 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "setText", "(ILandroid/widget/TextView$BufferType;)V");
			global::android.widget.TextView._getText17988 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "getText", "()Ljava/lang/CharSequence;");
			global::android.widget.TextView._getLayout17989 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "getLayout", "()Landroid/text/Layout;");
			global::android.widget.TextView._onRestoreInstanceState17990 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "onRestoreInstanceState", "(Landroid/os/Parcelable;)V");
			global::android.widget.TextView._onSaveInstanceState17991 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "onSaveInstanceState", "()Landroid/os/Parcelable;");
			global::android.widget.TextView._onKeyDown17992 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "onKeyDown", "(ILandroid/view/KeyEvent;)Z");
			global::android.widget.TextView._onKeyUp17993 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "onKeyUp", "(ILandroid/view/KeyEvent;)Z");
			global::android.widget.TextView._onKeyMultiple17994 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "onKeyMultiple", "(IILandroid/view/KeyEvent;)Z");
			global::android.widget.TextView._onTouchEvent17995 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "onTouchEvent", "(Landroid/view/MotionEvent;)Z");
			global::android.widget.TextView._onTrackballEvent17996 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "onTrackballEvent", "(Landroid/view/MotionEvent;)Z");
			global::android.widget.TextView._onWindowFocusChanged17997 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "onWindowFocusChanged", "(Z)V");
			global::android.widget.TextView._onAttachedToWindow17998 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "onAttachedToWindow", "()V");
			global::android.widget.TextView._onDetachedFromWindow17999 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "onDetachedFromWindow", "()V");
			global::android.widget.TextView._dispatchPopulateAccessibilityEvent18000 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "dispatchPopulateAccessibilityEvent", "(Landroid/view/accessibility/AccessibilityEvent;)Z");
			global::android.widget.TextView._onCreateContextMenu18001 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "onCreateContextMenu", "(Landroid/view/ContextMenu;)V");
			global::android.widget.TextView._setGravity18002 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "setGravity", "(I)V");
			global::android.widget.TextView._performLongClick18003 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "performLongClick", "()Z");
			global::android.widget.TextView._onFocusChanged18004 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "onFocusChanged", "(ZILandroid/graphics/Rect;)V");
			global::android.widget.TextView._onStartTemporaryDetach18005 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "onStartTemporaryDetach", "()V");
			global::android.widget.TextView._onFinishTemporaryDetach18006 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "onFinishTemporaryDetach", "()V");
			global::android.widget.TextView._onKeyShortcut18007 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "onKeyShortcut", "(ILandroid/view/KeyEvent;)Z");
			global::android.widget.TextView._onCheckIsTextEditor18008 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "onCheckIsTextEditor", "()Z");
			global::android.widget.TextView._onCreateInputConnection18009 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "onCreateInputConnection", "(Landroid/view/inputmethod/EditorInfo;)Landroid/view/inputmethod/InputConnection;");
			global::android.widget.TextView._cancelLongPress18010 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "cancelLongPress", "()V");
			global::android.widget.TextView._getFocusedRect18011 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "getFocusedRect", "(Landroid/graphics/Rect;)V");
			global::android.widget.TextView._computeScroll18012 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "computeScroll", "()V");
			global::android.widget.TextView._getLeftFadingEdgeStrength18013 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "getLeftFadingEdgeStrength", "()F");
			global::android.widget.TextView._getRightFadingEdgeStrength18014 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "getRightFadingEdgeStrength", "()F");
			global::android.widget.TextView._computeHorizontalScrollRange18015 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "computeHorizontalScrollRange", "()I");
			global::android.widget.TextView._computeVerticalScrollRange18016 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "computeVerticalScrollRange", "()I");
			global::android.widget.TextView._computeVerticalScrollExtent18017 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "computeVerticalScrollExtent", "()I");
			global::android.widget.TextView._onDraw18018 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "onDraw", "(Landroid/graphics/Canvas;)V");
			global::android.widget.TextView._isPaddingOffsetRequired18019 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "isPaddingOffsetRequired", "()Z");
			global::android.widget.TextView._getLeftPaddingOffset18020 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "getLeftPaddingOffset", "()I");
			global::android.widget.TextView._getRightPaddingOffset18021 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "getRightPaddingOffset", "()I");
			global::android.widget.TextView._getTopPaddingOffset18022 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "getTopPaddingOffset", "()I");
			global::android.widget.TextView._getBottomPaddingOffset18023 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "getBottomPaddingOffset", "()I");
			global::android.widget.TextView._invalidateDrawable18024 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "invalidateDrawable", "(Landroid/graphics/drawable/Drawable;)V");
			global::android.widget.TextView._verifyDrawable18025 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "verifyDrawable", "(Landroid/graphics/drawable/Drawable;)Z");
			global::android.widget.TextView._drawableStateChanged18026 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "drawableStateChanged", "()V");
			global::android.widget.TextView._setPadding18027 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "setPadding", "(IIII)V");
			global::android.widget.TextView._setSelected18028 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "setSelected", "(Z)V");
			global::android.widget.TextView._getBaseline18029 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "getBaseline", "()I");
			global::android.widget.TextView._onMeasure18030 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "onMeasure", "(II)V");
			global::android.widget.TextView._setTypeface18031 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "setTypeface", "(Landroid/graphics/Typeface;I)V");
			global::android.widget.TextView._setTypeface18032 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "setTypeface", "(Landroid/graphics/Typeface;)V");
			global::android.widget.TextView._getDefaultEditable18033 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "getDefaultEditable", "()Z");
			global::android.widget.TextView._getDefaultMovementMethod18034 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "getDefaultMovementMethod", "()Landroid/text/method/MovementMethod;");
			global::android.widget.TextView._getEditableText18035 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "getEditableText", "()Landroid/text/Editable;");
			global::android.widget.TextView._getLineHeight18036 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "getLineHeight", "()I");
			global::android.widget.TextView._getKeyListener18037 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "getKeyListener", "()Landroid/text/method/KeyListener;");
			global::android.widget.TextView._setKeyListener18038 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "setKeyListener", "(Landroid/text/method/KeyListener;)V");
			global::android.widget.TextView._getMovementMethod18039 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "getMovementMethod", "()Landroid/text/method/MovementMethod;");
			global::android.widget.TextView._setMovementMethod18040 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "setMovementMethod", "(Landroid/text/method/MovementMethod;)V");
			global::android.widget.TextView._getTransformationMethod18041 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "getTransformationMethod", "()Landroid/text/method/TransformationMethod;");
			global::android.widget.TextView._setTransformationMethod18042 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "setTransformationMethod", "(Landroid/text/method/TransformationMethod;)V");
			global::android.widget.TextView._getCompoundPaddingTop18043 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "getCompoundPaddingTop", "()I");
			global::android.widget.TextView._getCompoundPaddingBottom18044 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "getCompoundPaddingBottom", "()I");
			global::android.widget.TextView._getCompoundPaddingLeft18045 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "getCompoundPaddingLeft", "()I");
			global::android.widget.TextView._getCompoundPaddingRight18046 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "getCompoundPaddingRight", "()I");
			global::android.widget.TextView._getExtendedPaddingTop18047 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "getExtendedPaddingTop", "()I");
			global::android.widget.TextView._getExtendedPaddingBottom18048 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "getExtendedPaddingBottom", "()I");
			global::android.widget.TextView._getTotalPaddingLeft18049 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "getTotalPaddingLeft", "()I");
			global::android.widget.TextView._getTotalPaddingRight18050 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "getTotalPaddingRight", "()I");
			global::android.widget.TextView._getTotalPaddingTop18051 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "getTotalPaddingTop", "()I");
			global::android.widget.TextView._getTotalPaddingBottom18052 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "getTotalPaddingBottom", "()I");
			global::android.widget.TextView._setCompoundDrawables18053 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "setCompoundDrawables", "(Landroid/graphics/drawable/Drawable;Landroid/graphics/drawable/Drawable;Landroid/graphics/drawable/Drawable;Landroid/graphics/drawable/Drawable;)V");
			global::android.widget.TextView._setCompoundDrawablesWithIntrinsicBounds18054 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "setCompoundDrawablesWithIntrinsicBounds", "(Landroid/graphics/drawable/Drawable;Landroid/graphics/drawable/Drawable;Landroid/graphics/drawable/Drawable;Landroid/graphics/drawable/Drawable;)V");
			global::android.widget.TextView._setCompoundDrawablesWithIntrinsicBounds18055 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "setCompoundDrawablesWithIntrinsicBounds", "(IIII)V");
			global::android.widget.TextView._getCompoundDrawables18056 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "getCompoundDrawables", "()[Landroid/graphics/drawable/Drawable;");
			global::android.widget.TextView._setCompoundDrawablePadding18057 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "setCompoundDrawablePadding", "(I)V");
			global::android.widget.TextView._getCompoundDrawablePadding18058 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "getCompoundDrawablePadding", "()I");
			global::android.widget.TextView._getAutoLinkMask18059 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "getAutoLinkMask", "()I");
			global::android.widget.TextView._setTextAppearance18060 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "setTextAppearance", "(Landroid/content/Context;I)V");
			global::android.widget.TextView._getTextSize18061 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "getTextSize", "()F");
			global::android.widget.TextView._setTextSize18062 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "setTextSize", "(IF)V");
			global::android.widget.TextView._setTextSize18063 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "setTextSize", "(F)V");
			global::android.widget.TextView._getTextScaleX18064 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "getTextScaleX", "()F");
			global::android.widget.TextView._setTextScaleX18065 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "setTextScaleX", "(F)V");
			global::android.widget.TextView._getTypeface18066 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "getTypeface", "()Landroid/graphics/Typeface;");
			global::android.widget.TextView._setTextColor18067 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "setTextColor", "(I)V");
			global::android.widget.TextView._setTextColor18068 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "setTextColor", "(Landroid/content/res/ColorStateList;)V");
			global::android.widget.TextView._getTextColors18069 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "getTextColors", "()Landroid/content/res/ColorStateList;");
			global::android.widget.TextView._getTextColors18070 = @__env.GetStaticMethodIDNoThrow(global::android.widget.TextView.staticClass, "getTextColors", "(Landroid/content/Context;Landroid/content/res/TypedArray;)Landroid/content/res/ColorStateList;");
			global::android.widget.TextView._getCurrentTextColor18071 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "getCurrentTextColor", "()I");
			global::android.widget.TextView._setHighlightColor18072 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "setHighlightColor", "(I)V");
			global::android.widget.TextView._setShadowLayer18073 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "setShadowLayer", "(FFFI)V");
			global::android.widget.TextView._getPaint18074 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "getPaint", "()Landroid/text/TextPaint;");
			global::android.widget.TextView._setAutoLinkMask18075 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "setAutoLinkMask", "(I)V");
			global::android.widget.TextView._setLinksClickable18076 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "setLinksClickable", "(Z)V");
			global::android.widget.TextView._getLinksClickable18077 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "getLinksClickable", "()Z");
			global::android.widget.TextView._getUrls18078 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "getUrls", "()[Landroid/text/style/URLSpan;");
			global::android.widget.TextView._setHintTextColor18079 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "setHintTextColor", "(I)V");
			global::android.widget.TextView._setHintTextColor18080 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "setHintTextColor", "(Landroid/content/res/ColorStateList;)V");
			global::android.widget.TextView._getHintTextColors18081 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "getHintTextColors", "()Landroid/content/res/ColorStateList;");
			global::android.widget.TextView._getCurrentHintTextColor18082 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "getCurrentHintTextColor", "()I");
			global::android.widget.TextView._setLinkTextColor18083 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "setLinkTextColor", "(Landroid/content/res/ColorStateList;)V");
			global::android.widget.TextView._setLinkTextColor18084 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "setLinkTextColor", "(I)V");
			global::android.widget.TextView._getLinkTextColors18085 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "getLinkTextColors", "()Landroid/content/res/ColorStateList;");
			global::android.widget.TextView._getGravity18086 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "getGravity", "()I");
			global::android.widget.TextView._getPaintFlags18087 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "getPaintFlags", "()I");
			global::android.widget.TextView._setPaintFlags18088 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "setPaintFlags", "(I)V");
			global::android.widget.TextView._setHorizontallyScrolling18089 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "setHorizontallyScrolling", "(Z)V");
			global::android.widget.TextView._setMinLines18090 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "setMinLines", "(I)V");
			global::android.widget.TextView._setMinHeight18091 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "setMinHeight", "(I)V");
			global::android.widget.TextView._setMaxLines18092 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "setMaxLines", "(I)V");
			global::android.widget.TextView._setMaxHeight18093 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "setMaxHeight", "(I)V");
			global::android.widget.TextView._setLines18094 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "setLines", "(I)V");
			global::android.widget.TextView._setHeight18095 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "setHeight", "(I)V");
			global::android.widget.TextView._setMinEms18096 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "setMinEms", "(I)V");
			global::android.widget.TextView._setMinWidth18097 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "setMinWidth", "(I)V");
			global::android.widget.TextView._setMaxEms18098 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "setMaxEms", "(I)V");
			global::android.widget.TextView._setMaxWidth18099 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "setMaxWidth", "(I)V");
			global::android.widget.TextView._setEms18100 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "setEms", "(I)V");
			global::android.widget.TextView._setWidth18101 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "setWidth", "(I)V");
			global::android.widget.TextView._setLineSpacing18102 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "setLineSpacing", "(FF)V");
			global::android.widget.TextView._setFreezesText18103 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "setFreezesText", "(Z)V");
			global::android.widget.TextView._getFreezesText18104 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "getFreezesText", "()Z");
			global::android.widget.TextView._setEditableFactory18105 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "setEditableFactory", "(Landroid/text/Editable$Factory;)V");
			global::android.widget.TextView._setSpannableFactory18106 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "setSpannableFactory", "(Landroid/text/Spannable$Factory;)V");
			global::android.widget.TextView._setTextKeepState18107 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "setTextKeepState", "(Ljava/lang/CharSequence;Landroid/widget/TextView$BufferType;)V");
			global::android.widget.TextView._setTextKeepState18108 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "setTextKeepState", "(Ljava/lang/CharSequence;)V");
			global::android.widget.TextView._setHint18109 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "setHint", "(Ljava/lang/CharSequence;)V");
			global::android.widget.TextView._setHint18110 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "setHint", "(I)V");
			global::android.widget.TextView._getHint18111 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "getHint", "()Ljava/lang/CharSequence;");
			global::android.widget.TextView._setInputType18112 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "setInputType", "(I)V");
			global::android.widget.TextView._setRawInputType18113 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "setRawInputType", "(I)V");
			global::android.widget.TextView._getInputType18114 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "getInputType", "()I");
			global::android.widget.TextView._setImeOptions18115 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "setImeOptions", "(I)V");
			global::android.widget.TextView._getImeOptions18116 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "getImeOptions", "()I");
			global::android.widget.TextView._setImeActionLabel18117 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "setImeActionLabel", "(Ljava/lang/CharSequence;I)V");
			global::android.widget.TextView._getImeActionLabel18118 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "getImeActionLabel", "()Ljava/lang/CharSequence;");
			global::android.widget.TextView._getImeActionId18119 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "getImeActionId", "()I");
			global::android.widget.TextView._setOnEditorActionListener18120 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "setOnEditorActionListener", "(Landroid/widget/TextView$OnEditorActionListener;)V");
			global::android.widget.TextView._onEditorAction18121 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "onEditorAction", "(I)V");
			global::android.widget.TextView._setPrivateImeOptions18122 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "setPrivateImeOptions", "(Ljava/lang/String;)V");
			global::android.widget.TextView._getPrivateImeOptions18123 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "getPrivateImeOptions", "()Ljava/lang/String;");
			global::android.widget.TextView._setInputExtras18124 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "setInputExtras", "(I)V");
			global::android.widget.TextView._getInputExtras18125 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "getInputExtras", "(Z)Landroid/os/Bundle;");
			global::android.widget.TextView._getError18126 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "getError", "()Ljava/lang/CharSequence;");
			global::android.widget.TextView._setFrame18127 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "setFrame", "(IIII)Z");
			global::android.widget.TextView._setFilters18128 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "setFilters", "([Landroid/text/InputFilter;)V");
			global::android.widget.TextView._getFilters18129 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "getFilters", "()[Landroid/text/InputFilter;");
			global::android.widget.TextView._onPreDraw18130 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "onPreDraw", "()Z");
			global::android.widget.TextView._getLineCount18131 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "getLineCount", "()I");
			global::android.widget.TextView._getLineBounds18132 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "getLineBounds", "(ILandroid/graphics/Rect;)I");
			global::android.widget.TextView._extractText18133 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "extractText", "(Landroid/view/inputmethod/ExtractedTextRequest;Landroid/view/inputmethod/ExtractedText;)Z");
			global::android.widget.TextView._setExtractedText18134 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "setExtractedText", "(Landroid/view/inputmethod/ExtractedText;)V");
			global::android.widget.TextView._onCommitCompletion18135 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "onCommitCompletion", "(Landroid/view/inputmethod/CompletionInfo;)V");
			global::android.widget.TextView._beginBatchEdit18136 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "beginBatchEdit", "()V");
			global::android.widget.TextView._endBatchEdit18137 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "endBatchEdit", "()V");
			global::android.widget.TextView._onBeginBatchEdit18138 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "onBeginBatchEdit", "()V");
			global::android.widget.TextView._onEndBatchEdit18139 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "onEndBatchEdit", "()V");
			global::android.widget.TextView._onPrivateIMECommand18140 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "onPrivateIMECommand", "(Ljava/lang/String;Landroid/os/Bundle;)Z");
			global::android.widget.TextView._setIncludeFontPadding18141 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "setIncludeFontPadding", "(Z)V");
			global::android.widget.TextView._bringPointIntoView18142 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "bringPointIntoView", "(I)Z");
			global::android.widget.TextView._moveCursorToVisibleOffset18143 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "moveCursorToVisibleOffset", "()Z");
			global::android.widget.TextView._getSelectionStart18144 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "getSelectionStart", "()I");
			global::android.widget.TextView._getSelectionEnd18145 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "getSelectionEnd", "()I");
			global::android.widget.TextView._hasSelection18146 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "hasSelection", "()Z");
			global::android.widget.TextView._setSingleLine18147 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "setSingleLine", "()V");
			global::android.widget.TextView._setSingleLine18148 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "setSingleLine", "(Z)V");
			global::android.widget.TextView._setEllipsize18149 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "setEllipsize", "(Landroid/text/TextUtils$TruncateAt;)V");
			global::android.widget.TextView._setMarqueeRepeatLimit18150 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "setMarqueeRepeatLimit", "(I)V");
			global::android.widget.TextView._getEllipsize18151 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "getEllipsize", "()Landroid/text/TextUtils$TruncateAt;");
			global::android.widget.TextView._setSelectAllOnFocus18152 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "setSelectAllOnFocus", "(Z)V");
			global::android.widget.TextView._setCursorVisible18153 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "setCursorVisible", "(Z)V");
			global::android.widget.TextView._onTextChanged18154 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "onTextChanged", "(Ljava/lang/CharSequence;III)V");
			global::android.widget.TextView._onSelectionChanged18155 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "onSelectionChanged", "(II)V");
			global::android.widget.TextView._addTextChangedListener18156 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "addTextChangedListener", "(Landroid/text/TextWatcher;)V");
			global::android.widget.TextView._removeTextChangedListener18157 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "removeTextChangedListener", "(Landroid/text/TextWatcher;)V");
			global::android.widget.TextView._clearComposingText18158 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "clearComposingText", "()V");
			global::android.widget.TextView._didTouchFocusSelect18159 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "didTouchFocusSelect", "()Z");
			global::android.widget.TextView._setScroller18160 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "setScroller", "(Landroid/widget/Scroller;)V");
			global::android.widget.TextView._getTextColor18161 = @__env.GetStaticMethodIDNoThrow(global::android.widget.TextView.staticClass, "getTextColor", "(Landroid/content/Context;Landroid/content/res/TypedArray;I)I");
			global::android.widget.TextView._isInputMethodTarget18162 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "isInputMethodTarget", "()Z");
			global::android.widget.TextView._onTextContextMenuItem18163 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "onTextContextMenuItem", "(I)Z");
			global::android.widget.TextView._TextView18164 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			global::android.widget.TextView._TextView18165 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "<init>", "(Landroid/content/Context;)V");
			global::android.widget.TextView._TextView18166 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V");
		}
	}
}
