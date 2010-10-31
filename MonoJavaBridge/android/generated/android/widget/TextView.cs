namespace android.widget
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class TextView : android.view.View, android.view.ViewTreeObserver.OnPreDrawListener
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected TextView(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaClass()]
		public sealed partial class BufferType : java.lang.Enum
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			internal BufferType(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			public static global::android.widget.TextView.BufferType[] values()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.widget.TextView.BufferType._m0.native == global::System.IntPtr.Zero)
					global::android.widget.TextView.BufferType._m0 = @__env.GetStaticMethodIDNoThrow(global::android.widget.TextView.BufferType.staticClass, "values", "()[Landroid/widget/TextView/BufferType;");
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<android.widget.TextView.BufferType>(@__env.CallStaticObjectMethod(android.widget.TextView.BufferType.staticClass, global::android.widget.TextView.BufferType._m0)) as android.widget.TextView.BufferType[];
			}
			private static global::MonoJavaBridge.MethodId _m1;
			public static global::android.widget.TextView.BufferType valueOf(java.lang.String arg0)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.widget.TextView.BufferType._m1.native == global::System.IntPtr.Zero)
					global::android.widget.TextView.BufferType._m1 = @__env.GetStaticMethodIDNoThrow(global::android.widget.TextView.BufferType.staticClass, "valueOf", "(Ljava/lang/String;)Landroid/widget/TextView$BufferType;");
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.widget.TextView.BufferType>(@__env.CallStaticObjectMethod(android.widget.TextView.BufferType.staticClass, global::android.widget.TextView.BufferType._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.widget.TextView.BufferType;
			}
			internal static global::MonoJavaBridge.FieldId _EDITABLE6107;
			public static global::android.widget.TextView.BufferType EDITABLE
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.widget.TextView.BufferType>(@__env.GetStaticObjectField(global::android.widget.TextView.BufferType.staticClass, _EDITABLE6107)) as android.widget.TextView.BufferType;
				}
			}
			internal static global::MonoJavaBridge.FieldId _NORMAL6108;
			public static global::android.widget.TextView.BufferType NORMAL
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.widget.TextView.BufferType>(@__env.GetStaticObjectField(global::android.widget.TextView.BufferType.staticClass, _NORMAL6108)) as android.widget.TextView.BufferType;
				}
			}
			internal static global::MonoJavaBridge.FieldId _SPANNABLE6109;
			public static global::android.widget.TextView.BufferType SPANNABLE
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.widget.TextView.BufferType>(@__env.GetStaticObjectField(global::android.widget.TextView.BufferType.staticClass, _SPANNABLE6109)) as android.widget.TextView.BufferType;
				}
			}
			static BufferType()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.widget.TextView.BufferType.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/TextView$BufferType"));
				global::android.widget.TextView.BufferType._EDITABLE6107 = @__env.GetStaticFieldIDNoThrow(global::android.widget.TextView.BufferType.staticClass, "EDITABLE", "Landroid/widget/TextView$BufferType;");
				global::android.widget.TextView.BufferType._NORMAL6108 = @__env.GetStaticFieldIDNoThrow(global::android.widget.TextView.BufferType.staticClass, "NORMAL", "Landroid/widget/TextView$BufferType;");
				global::android.widget.TextView.BufferType._SPANNABLE6109 = @__env.GetStaticFieldIDNoThrow(global::android.widget.TextView.BufferType.staticClass, "SPANNABLE", "Landroid/widget/TextView$BufferType;");
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
			internal OnEditorActionListener_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			bool android.widget.TextView.OnEditorActionListener.onEditorAction(android.widget.TextView arg0, int arg1, android.view.KeyEvent arg2)
			{
				return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.TextView.OnEditorActionListener_.staticClass, "onEditorAction", "(Landroid/widget/TextView;ILandroid/view/KeyEvent;)Z", ref global::android.widget.TextView.OnEditorActionListener_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			}
			static OnEditorActionListener_()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.widget.TextView.OnEditorActionListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/TextView$OnEditorActionListener"));
			}
		}

		public delegate bool OnEditorActionListenerDelegate(android.widget.TextView arg0, int arg1, android.view.KeyEvent arg2);

		internal partial class OnEditorActionListenerDelegateWrapper : java.lang.Object, OnEditorActionListener
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			protected OnEditorActionListenerDelegateWrapper(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			public OnEditorActionListenerDelegateWrapper() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.widget.TextView.OnEditorActionListenerDelegateWrapper._m0.native == global::System.IntPtr.Zero)
					global::android.widget.TextView.OnEditorActionListenerDelegateWrapper._m0 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.OnEditorActionListenerDelegateWrapper.staticClass, "<init>", "()V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.TextView.OnEditorActionListenerDelegateWrapper.staticClass, global::android.widget.TextView.OnEditorActionListenerDelegateWrapper._m0);
				Init(@__env, handle);
			}
			static OnEditorActionListenerDelegateWrapper()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.widget.TextView.OnEditorActionListenerDelegateWrapper.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/TextView_OnEditorActionListenerDelegateWrapper"));
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
			protected SavedState(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			public override global::java.lang.String toString()
			{
				return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.widget.TextView.SavedState.staticClass, "toString", "()Ljava/lang/String;", ref global::android.widget.TextView.SavedState._m0) as java.lang.String;
			}
			private static global::MonoJavaBridge.MethodId _m1;
			public override void writeToParcel(android.os.Parcel arg0, int arg1)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.TextView.SavedState.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V", ref global::android.widget.TextView.SavedState._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			internal static global::MonoJavaBridge.FieldId _CREATOR6110;
			public static global::android.os.Parcelable_Creator CREATOR
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.Parcelable_Creator>(@__env.GetStaticObjectField(global::android.widget.TextView.SavedState.staticClass, _CREATOR6110)) as android.os.Parcelable_Creator;
				}
			}
			static SavedState()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.widget.TextView.SavedState.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/TextView$SavedState"));
				global::android.widget.TextView.SavedState._CREATOR6110 = @__env.GetStaticFieldIDNoThrow(global::android.widget.TextView.SavedState.staticClass, "CREATOR", "Landroid/os/Parcelable$Creator;");
			}
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual void append(java.lang.CharSequence arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.TextView.staticClass, "append", "(Ljava/lang/CharSequence;)V", ref global::android.widget.TextView._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public void append(string arg0)
		{
			append((global::java.lang.CharSequence)(global::java.lang.String)arg0);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual void append(java.lang.CharSequence arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.TextView.staticClass, "append", "(Ljava/lang/CharSequence;II)V", ref global::android.widget.TextView._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		public void append(string arg0, int arg1, int arg2)
		{
			append((global::java.lang.CharSequence)(global::java.lang.String)arg0, arg1, arg2);
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual int length()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.widget.TextView.staticClass, "length", "()I", ref global::android.widget.TextView._m2);
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual void debug(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.TextView.staticClass, "debug", "(I)V", ref global::android.widget.TextView._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual void setError(java.lang.CharSequence arg0, android.graphics.drawable.Drawable arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.TextView.staticClass, "setError", "(Ljava/lang/CharSequence;Landroid/graphics/drawable/Drawable;)V", ref global::android.widget.TextView._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public void setError(string arg0, android.graphics.drawable.Drawable arg1)
		{
			setError((global::java.lang.CharSequence)(global::java.lang.String)arg0, arg1);
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual void setError(java.lang.CharSequence arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.TextView.staticClass, "setError", "(Ljava/lang/CharSequence;)V", ref global::android.widget.TextView._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public void setError(string arg0)
		{
			setError((global::java.lang.CharSequence)(global::java.lang.String)arg0);
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public virtual void setText(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.TextView.staticClass, "setText", "(I)V", ref global::android.widget.TextView._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public virtual void setText(java.lang.CharSequence arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.TextView.staticClass, "setText", "(Ljava/lang/CharSequence;)V", ref global::android.widget.TextView._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public void setText(string arg0)
		{
			setText((global::java.lang.CharSequence)(global::java.lang.String)arg0);
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public virtual void setText(java.lang.CharSequence arg0, android.widget.TextView.BufferType arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.TextView.staticClass, "setText", "(Ljava/lang/CharSequence;Landroid/widget/TextView$BufferType;)V", ref global::android.widget.TextView._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public void setText(string arg0, android.widget.TextView.BufferType arg1)
		{
			setText((global::java.lang.CharSequence)(global::java.lang.String)arg0, arg1);
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public virtual void setText(char[] arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.TextView.staticClass, "setText", "([CII)V", ref global::android.widget.TextView._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public virtual void setText(int arg0, android.widget.TextView.BufferType arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.TextView.staticClass, "setText", "(ILandroid/widget/TextView$BufferType;)V", ref global::android.widget.TextView._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
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
		private static global::MonoJavaBridge.MethodId _m11;
		public virtual global::java.lang.CharSequence getText()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.lang.CharSequence>(this, global::android.widget.TextView.staticClass, "getText", "()Ljava/lang/CharSequence;", ref global::android.widget.TextView._m11) as java.lang.CharSequence;
		}
		public new global::android.text.Layout Layout
		{
			get
			{
				return getLayout();
			}
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public virtual global::android.text.Layout getLayout()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.widget.TextView.staticClass, "getLayout", "()Landroid/text/Layout;", ref global::android.widget.TextView._m12) as android.text.Layout;
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public virtual void onRestoreInstanceState(android.os.Parcelable arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.TextView.staticClass, "onRestoreInstanceState", "(Landroid/os/Parcelable;)V", ref global::android.widget.TextView._m13, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m14;
		public virtual global::android.os.Parcelable onSaveInstanceState()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<android.os.Parcelable>(this, global::android.widget.TextView.staticClass, "onSaveInstanceState", "()Landroid/os/Parcelable;", ref global::android.widget.TextView._m14) as android.os.Parcelable;
		}
		private static global::MonoJavaBridge.MethodId _m15;
		public override bool onKeyDown(int arg0, android.view.KeyEvent arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.TextView.staticClass, "onKeyDown", "(ILandroid/view/KeyEvent;)Z", ref global::android.widget.TextView._m15, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m16;
		public override bool onKeyUp(int arg0, android.view.KeyEvent arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.TextView.staticClass, "onKeyUp", "(ILandroid/view/KeyEvent;)Z", ref global::android.widget.TextView._m16, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m17;
		public override bool onKeyMultiple(int arg0, int arg1, android.view.KeyEvent arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.TextView.staticClass, "onKeyMultiple", "(IILandroid/view/KeyEvent;)Z", ref global::android.widget.TextView._m17, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m18;
		public override bool onTouchEvent(android.view.MotionEvent arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.TextView.staticClass, "onTouchEvent", "(Landroid/view/MotionEvent;)Z", ref global::android.widget.TextView._m18, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m19;
		public override bool onTrackballEvent(android.view.MotionEvent arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.TextView.staticClass, "onTrackballEvent", "(Landroid/view/MotionEvent;)Z", ref global::android.widget.TextView._m19, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m20;
		public override void onWindowFocusChanged(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.TextView.staticClass, "onWindowFocusChanged", "(Z)V", ref global::android.widget.TextView._m20, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m21;
		protected override void onAttachedToWindow()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.TextView.staticClass, "onAttachedToWindow", "()V", ref global::android.widget.TextView._m21);
		}
		private static global::MonoJavaBridge.MethodId _m22;
		protected override void onDetachedFromWindow()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.TextView.staticClass, "onDetachedFromWindow", "()V", ref global::android.widget.TextView._m22);
		}
		private static global::MonoJavaBridge.MethodId _m23;
		public override bool dispatchPopulateAccessibilityEvent(android.view.accessibility.AccessibilityEvent arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.TextView.staticClass, "dispatchPopulateAccessibilityEvent", "(Landroid/view/accessibility/AccessibilityEvent;)Z", ref global::android.widget.TextView._m23, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m24;
		protected override void onCreateContextMenu(android.view.ContextMenu arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.TextView.staticClass, "onCreateContextMenu", "(Landroid/view/ContextMenu;)V", ref global::android.widget.TextView._m24, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m25;
		public virtual void setGravity(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.TextView.staticClass, "setGravity", "(I)V", ref global::android.widget.TextView._m25, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m26;
		public override bool performLongClick()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.TextView.staticClass, "performLongClick", "()Z", ref global::android.widget.TextView._m26);
		}
		private static global::MonoJavaBridge.MethodId _m27;
		protected override void onFocusChanged(bool arg0, int arg1, android.graphics.Rect arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.TextView.staticClass, "onFocusChanged", "(ZILandroid/graphics/Rect;)V", ref global::android.widget.TextView._m27, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m28;
		public override void onStartTemporaryDetach()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.TextView.staticClass, "onStartTemporaryDetach", "()V", ref global::android.widget.TextView._m28);
		}
		private static global::MonoJavaBridge.MethodId _m29;
		public override void onFinishTemporaryDetach()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.TextView.staticClass, "onFinishTemporaryDetach", "()V", ref global::android.widget.TextView._m29);
		}
		private static global::MonoJavaBridge.MethodId _m30;
		public override bool onKeyShortcut(int arg0, android.view.KeyEvent arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.TextView.staticClass, "onKeyShortcut", "(ILandroid/view/KeyEvent;)Z", ref global::android.widget.TextView._m30, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m31;
		public override bool onCheckIsTextEditor()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.TextView.staticClass, "onCheckIsTextEditor", "()Z", ref global::android.widget.TextView._m31);
		}
		private static global::MonoJavaBridge.MethodId _m32;
		public override global::android.view.inputmethod.InputConnection onCreateInputConnection(android.view.inputmethod.EditorInfo arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<android.view.inputmethod.InputConnection>(this, global::android.widget.TextView.staticClass, "onCreateInputConnection", "(Landroid/view/inputmethod/EditorInfo;)Landroid/view/inputmethod/InputConnection;", ref global::android.widget.TextView._m32, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.view.inputmethod.InputConnection;
		}
		private static global::MonoJavaBridge.MethodId _m33;
		public override void cancelLongPress()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.TextView.staticClass, "cancelLongPress", "()V", ref global::android.widget.TextView._m33);
		}
		private static global::MonoJavaBridge.MethodId _m34;
		public override void getFocusedRect(android.graphics.Rect arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.TextView.staticClass, "getFocusedRect", "(Landroid/graphics/Rect;)V", ref global::android.widget.TextView._m34, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m35;
		public override void computeScroll()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.TextView.staticClass, "computeScroll", "()V", ref global::android.widget.TextView._m35);
		}
		protected new float LeftFadingEdgeStrength
		{
			get
			{
				return getLeftFadingEdgeStrength();
			}
		}
		private static global::MonoJavaBridge.MethodId _m36;
		protected override float getLeftFadingEdgeStrength()
		{
			return global::MonoJavaBridge.JavaBridge.CallFloatMethod(this, global::android.widget.TextView.staticClass, "getLeftFadingEdgeStrength", "()F", ref global::android.widget.TextView._m36);
		}
		protected new float RightFadingEdgeStrength
		{
			get
			{
				return getRightFadingEdgeStrength();
			}
		}
		private static global::MonoJavaBridge.MethodId _m37;
		protected override float getRightFadingEdgeStrength()
		{
			return global::MonoJavaBridge.JavaBridge.CallFloatMethod(this, global::android.widget.TextView.staticClass, "getRightFadingEdgeStrength", "()F", ref global::android.widget.TextView._m37);
		}
		private static global::MonoJavaBridge.MethodId _m38;
		protected override int computeHorizontalScrollRange()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.widget.TextView.staticClass, "computeHorizontalScrollRange", "()I", ref global::android.widget.TextView._m38);
		}
		private static global::MonoJavaBridge.MethodId _m39;
		protected override int computeVerticalScrollRange()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.widget.TextView.staticClass, "computeVerticalScrollRange", "()I", ref global::android.widget.TextView._m39);
		}
		private static global::MonoJavaBridge.MethodId _m40;
		protected override int computeVerticalScrollExtent()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.widget.TextView.staticClass, "computeVerticalScrollExtent", "()I", ref global::android.widget.TextView._m40);
		}
		private static global::MonoJavaBridge.MethodId _m41;
		protected override void onDraw(android.graphics.Canvas arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.TextView.staticClass, "onDraw", "(Landroid/graphics/Canvas;)V", ref global::android.widget.TextView._m41, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m42;
		protected override bool isPaddingOffsetRequired()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.TextView.staticClass, "isPaddingOffsetRequired", "()Z", ref global::android.widget.TextView._m42);
		}
		protected new int LeftPaddingOffset
		{
			get
			{
				return getLeftPaddingOffset();
			}
		}
		private static global::MonoJavaBridge.MethodId _m43;
		protected override int getLeftPaddingOffset()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.widget.TextView.staticClass, "getLeftPaddingOffset", "()I", ref global::android.widget.TextView._m43);
		}
		protected new int RightPaddingOffset
		{
			get
			{
				return getRightPaddingOffset();
			}
		}
		private static global::MonoJavaBridge.MethodId _m44;
		protected override int getRightPaddingOffset()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.widget.TextView.staticClass, "getRightPaddingOffset", "()I", ref global::android.widget.TextView._m44);
		}
		protected new int TopPaddingOffset
		{
			get
			{
				return getTopPaddingOffset();
			}
		}
		private static global::MonoJavaBridge.MethodId _m45;
		protected override int getTopPaddingOffset()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.widget.TextView.staticClass, "getTopPaddingOffset", "()I", ref global::android.widget.TextView._m45);
		}
		protected new int BottomPaddingOffset
		{
			get
			{
				return getBottomPaddingOffset();
			}
		}
		private static global::MonoJavaBridge.MethodId _m46;
		protected override int getBottomPaddingOffset()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.widget.TextView.staticClass, "getBottomPaddingOffset", "()I", ref global::android.widget.TextView._m46);
		}
		private static global::MonoJavaBridge.MethodId _m47;
		public override void invalidateDrawable(android.graphics.drawable.Drawable arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.TextView.staticClass, "invalidateDrawable", "(Landroid/graphics/drawable/Drawable;)V", ref global::android.widget.TextView._m47, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m48;
		protected override bool verifyDrawable(android.graphics.drawable.Drawable arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.TextView.staticClass, "verifyDrawable", "(Landroid/graphics/drawable/Drawable;)Z", ref global::android.widget.TextView._m48, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m49;
		protected override void drawableStateChanged()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.TextView.staticClass, "drawableStateChanged", "()V", ref global::android.widget.TextView._m49);
		}
		private static global::MonoJavaBridge.MethodId _m50;
		public override void setPadding(int arg0, int arg1, int arg2, int arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.TextView.staticClass, "setPadding", "(IIII)V", ref global::android.widget.TextView._m50, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		public new bool Selected
		{
			set
			{
				setSelected(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m51;
		public override void setSelected(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.TextView.staticClass, "setSelected", "(Z)V", ref global::android.widget.TextView._m51, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int Baseline
		{
			get
			{
				return getBaseline();
			}
		}
		private static global::MonoJavaBridge.MethodId _m52;
		public override int getBaseline()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.widget.TextView.staticClass, "getBaseline", "()I", ref global::android.widget.TextView._m52);
		}
		private static global::MonoJavaBridge.MethodId _m53;
		protected override void onMeasure(int arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.TextView.staticClass, "onMeasure", "(II)V", ref global::android.widget.TextView._m53, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m54;
		public virtual void setTypeface(android.graphics.Typeface arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.TextView.staticClass, "setTypeface", "(Landroid/graphics/Typeface;I)V", ref global::android.widget.TextView._m54, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m55;
		public virtual void setTypeface(android.graphics.Typeface arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.TextView.staticClass, "setTypeface", "(Landroid/graphics/Typeface;)V", ref global::android.widget.TextView._m55, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		protected new bool DefaultEditable
		{
			get
			{
				return getDefaultEditable();
			}
		}
		private static global::MonoJavaBridge.MethodId _m56;
		protected virtual bool getDefaultEditable()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.TextView.staticClass, "getDefaultEditable", "()Z", ref global::android.widget.TextView._m56);
		}
		protected new global::android.text.method.MovementMethod DefaultMovementMethod
		{
			get
			{
				return getDefaultMovementMethod();
			}
		}
		private static global::MonoJavaBridge.MethodId _m57;
		protected virtual global::android.text.method.MovementMethod getDefaultMovementMethod()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<android.text.method.MovementMethod>(this, global::android.widget.TextView.staticClass, "getDefaultMovementMethod", "()Landroid/text/method/MovementMethod;", ref global::android.widget.TextView._m57) as android.text.method.MovementMethod;
		}
		public new global::android.text.Editable EditableText
		{
			get
			{
				return getEditableText();
			}
		}
		private static global::MonoJavaBridge.MethodId _m58;
		public virtual global::android.text.Editable getEditableText()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<android.text.Editable>(this, global::android.widget.TextView.staticClass, "getEditableText", "()Landroid/text/Editable;", ref global::android.widget.TextView._m58) as android.text.Editable;
		}
		public new int LineHeight
		{
			get
			{
				return getLineHeight();
			}
		}
		private static global::MonoJavaBridge.MethodId _m59;
		public virtual int getLineHeight()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.widget.TextView.staticClass, "getLineHeight", "()I", ref global::android.widget.TextView._m59);
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
		private static global::MonoJavaBridge.MethodId _m60;
		public virtual global::android.text.method.KeyListener getKeyListener()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<android.text.method.KeyListener>(this, global::android.widget.TextView.staticClass, "getKeyListener", "()Landroid/text/method/KeyListener;", ref global::android.widget.TextView._m60) as android.text.method.KeyListener;
		}
		private static global::MonoJavaBridge.MethodId _m61;
		public virtual void setKeyListener(android.text.method.KeyListener arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.TextView.staticClass, "setKeyListener", "(Landroid/text/method/KeyListener;)V", ref global::android.widget.TextView._m61, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		private static global::MonoJavaBridge.MethodId _m62;
		public virtual global::android.text.method.MovementMethod getMovementMethod()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<android.text.method.MovementMethod>(this, global::android.widget.TextView.staticClass, "getMovementMethod", "()Landroid/text/method/MovementMethod;", ref global::android.widget.TextView._m62) as android.text.method.MovementMethod;
		}
		private static global::MonoJavaBridge.MethodId _m63;
		public virtual void setMovementMethod(android.text.method.MovementMethod arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.TextView.staticClass, "setMovementMethod", "(Landroid/text/method/MovementMethod;)V", ref global::android.widget.TextView._m63, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		private static global::MonoJavaBridge.MethodId _m64;
		public virtual global::android.text.method.TransformationMethod getTransformationMethod()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<android.text.method.TransformationMethod>(this, global::android.widget.TextView.staticClass, "getTransformationMethod", "()Landroid/text/method/TransformationMethod;", ref global::android.widget.TextView._m64) as android.text.method.TransformationMethod;
		}
		private static global::MonoJavaBridge.MethodId _m65;
		public virtual void setTransformationMethod(android.text.method.TransformationMethod arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.TextView.staticClass, "setTransformationMethod", "(Landroid/text/method/TransformationMethod;)V", ref global::android.widget.TextView._m65, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int CompoundPaddingTop
		{
			get
			{
				return getCompoundPaddingTop();
			}
		}
		private static global::MonoJavaBridge.MethodId _m66;
		public virtual int getCompoundPaddingTop()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.widget.TextView.staticClass, "getCompoundPaddingTop", "()I", ref global::android.widget.TextView._m66);
		}
		public new int CompoundPaddingBottom
		{
			get
			{
				return getCompoundPaddingBottom();
			}
		}
		private static global::MonoJavaBridge.MethodId _m67;
		public virtual int getCompoundPaddingBottom()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.widget.TextView.staticClass, "getCompoundPaddingBottom", "()I", ref global::android.widget.TextView._m67);
		}
		public new int CompoundPaddingLeft
		{
			get
			{
				return getCompoundPaddingLeft();
			}
		}
		private static global::MonoJavaBridge.MethodId _m68;
		public virtual int getCompoundPaddingLeft()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.widget.TextView.staticClass, "getCompoundPaddingLeft", "()I", ref global::android.widget.TextView._m68);
		}
		public new int CompoundPaddingRight
		{
			get
			{
				return getCompoundPaddingRight();
			}
		}
		private static global::MonoJavaBridge.MethodId _m69;
		public virtual int getCompoundPaddingRight()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.widget.TextView.staticClass, "getCompoundPaddingRight", "()I", ref global::android.widget.TextView._m69);
		}
		public new int ExtendedPaddingTop
		{
			get
			{
				return getExtendedPaddingTop();
			}
		}
		private static global::MonoJavaBridge.MethodId _m70;
		public virtual int getExtendedPaddingTop()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.widget.TextView.staticClass, "getExtendedPaddingTop", "()I", ref global::android.widget.TextView._m70);
		}
		public new int ExtendedPaddingBottom
		{
			get
			{
				return getExtendedPaddingBottom();
			}
		}
		private static global::MonoJavaBridge.MethodId _m71;
		public virtual int getExtendedPaddingBottom()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.widget.TextView.staticClass, "getExtendedPaddingBottom", "()I", ref global::android.widget.TextView._m71);
		}
		public new int TotalPaddingLeft
		{
			get
			{
				return getTotalPaddingLeft();
			}
		}
		private static global::MonoJavaBridge.MethodId _m72;
		public virtual int getTotalPaddingLeft()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.widget.TextView.staticClass, "getTotalPaddingLeft", "()I", ref global::android.widget.TextView._m72);
		}
		public new int TotalPaddingRight
		{
			get
			{
				return getTotalPaddingRight();
			}
		}
		private static global::MonoJavaBridge.MethodId _m73;
		public virtual int getTotalPaddingRight()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.widget.TextView.staticClass, "getTotalPaddingRight", "()I", ref global::android.widget.TextView._m73);
		}
		public new int TotalPaddingTop
		{
			get
			{
				return getTotalPaddingTop();
			}
		}
		private static global::MonoJavaBridge.MethodId _m74;
		public virtual int getTotalPaddingTop()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.widget.TextView.staticClass, "getTotalPaddingTop", "()I", ref global::android.widget.TextView._m74);
		}
		public new int TotalPaddingBottom
		{
			get
			{
				return getTotalPaddingBottom();
			}
		}
		private static global::MonoJavaBridge.MethodId _m75;
		public virtual int getTotalPaddingBottom()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.widget.TextView.staticClass, "getTotalPaddingBottom", "()I", ref global::android.widget.TextView._m75);
		}
		private static global::MonoJavaBridge.MethodId _m76;
		public virtual void setCompoundDrawables(android.graphics.drawable.Drawable arg0, android.graphics.drawable.Drawable arg1, android.graphics.drawable.Drawable arg2, android.graphics.drawable.Drawable arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.TextView.staticClass, "setCompoundDrawables", "(Landroid/graphics/drawable/Drawable;Landroid/graphics/drawable/Drawable;Landroid/graphics/drawable/Drawable;Landroid/graphics/drawable/Drawable;)V", ref global::android.widget.TextView._m76, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m77;
		public virtual void setCompoundDrawablesWithIntrinsicBounds(android.graphics.drawable.Drawable arg0, android.graphics.drawable.Drawable arg1, android.graphics.drawable.Drawable arg2, android.graphics.drawable.Drawable arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.TextView.staticClass, "setCompoundDrawablesWithIntrinsicBounds", "(Landroid/graphics/drawable/Drawable;Landroid/graphics/drawable/Drawable;Landroid/graphics/drawable/Drawable;Landroid/graphics/drawable/Drawable;)V", ref global::android.widget.TextView._m77, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m78;
		public virtual void setCompoundDrawablesWithIntrinsicBounds(int arg0, int arg1, int arg2, int arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.TextView.staticClass, "setCompoundDrawablesWithIntrinsicBounds", "(IIII)V", ref global::android.widget.TextView._m78, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		public new global::android.graphics.drawable.Drawable[] CompoundDrawables
		{
			get
			{
				return getCompoundDrawables();
			}
		}
		private static global::MonoJavaBridge.MethodId _m79;
		public virtual global::android.graphics.drawable.Drawable[] getCompoundDrawables()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<android.graphics.drawable.Drawable>(this, global::android.widget.TextView.staticClass, "getCompoundDrawables", "()[Landroid/graphics/drawable/Drawable;", ref global::android.widget.TextView._m79) as android.graphics.drawable.Drawable[];
		}
		private static global::MonoJavaBridge.MethodId _m80;
		public virtual void setCompoundDrawablePadding(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.TextView.staticClass, "setCompoundDrawablePadding", "(I)V", ref global::android.widget.TextView._m80, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		private static global::MonoJavaBridge.MethodId _m81;
		public virtual int getCompoundDrawablePadding()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.widget.TextView.staticClass, "getCompoundDrawablePadding", "()I", ref global::android.widget.TextView._m81);
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
		private static global::MonoJavaBridge.MethodId _m82;
		public virtual int getAutoLinkMask()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.widget.TextView.staticClass, "getAutoLinkMask", "()I", ref global::android.widget.TextView._m82);
		}
		private static global::MonoJavaBridge.MethodId _m83;
		public virtual void setTextAppearance(android.content.Context arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.TextView.staticClass, "setTextAppearance", "(Landroid/content/Context;I)V", ref global::android.widget.TextView._m83, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
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
		private static global::MonoJavaBridge.MethodId _m84;
		public virtual float getTextSize()
		{
			return global::MonoJavaBridge.JavaBridge.CallFloatMethod(this, global::android.widget.TextView.staticClass, "getTextSize", "()F", ref global::android.widget.TextView._m84);
		}
		private static global::MonoJavaBridge.MethodId _m85;
		public virtual void setTextSize(int arg0, float arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.TextView.staticClass, "setTextSize", "(IF)V", ref global::android.widget.TextView._m85, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m86;
		public virtual void setTextSize(float arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.TextView.staticClass, "setTextSize", "(F)V", ref global::android.widget.TextView._m86, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		private static global::MonoJavaBridge.MethodId _m87;
		public virtual float getTextScaleX()
		{
			return global::MonoJavaBridge.JavaBridge.CallFloatMethod(this, global::android.widget.TextView.staticClass, "getTextScaleX", "()F", ref global::android.widget.TextView._m87);
		}
		private static global::MonoJavaBridge.MethodId _m88;
		public virtual void setTextScaleX(float arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.TextView.staticClass, "setTextScaleX", "(F)V", ref global::android.widget.TextView._m88, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		private static global::MonoJavaBridge.MethodId _m89;
		public virtual global::android.graphics.Typeface getTypeface()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.widget.TextView.staticClass, "getTypeface", "()Landroid/graphics/Typeface;", ref global::android.widget.TextView._m89) as android.graphics.Typeface;
		}
		private static global::MonoJavaBridge.MethodId _m90;
		public virtual void setTextColor(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.TextView.staticClass, "setTextColor", "(I)V", ref global::android.widget.TextView._m90, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m91;
		public virtual void setTextColor(android.content.res.ColorStateList arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.TextView.staticClass, "setTextColor", "(Landroid/content/res/ColorStateList;)V", ref global::android.widget.TextView._m91, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::android.content.res.ColorStateList TextColors
		{
			get
			{
				return getTextColors();
			}
		}
		private static global::MonoJavaBridge.MethodId _m92;
		public virtual global::android.content.res.ColorStateList getTextColors()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.widget.TextView.staticClass, "getTextColors", "()Landroid/content/res/ColorStateList;", ref global::android.widget.TextView._m92) as android.content.res.ColorStateList;
		}
		private static global::MonoJavaBridge.MethodId _m93;
		public static global::android.content.res.ColorStateList getTextColors(android.content.Context arg0, android.content.res.TypedArray arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.TextView._m93.native == global::System.IntPtr.Zero)
				global::android.widget.TextView._m93 = @__env.GetStaticMethodIDNoThrow(global::android.widget.TextView.staticClass, "getTextColors", "(Landroid/content/Context;Landroid/content/res/TypedArray;)Landroid/content/res/ColorStateList;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.widget.TextView.staticClass, global::android.widget.TextView._m93, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.res.ColorStateList;
		}
		public new int CurrentTextColor
		{
			get
			{
				return getCurrentTextColor();
			}
		}
		private static global::MonoJavaBridge.MethodId _m94;
		public virtual int getCurrentTextColor()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.widget.TextView.staticClass, "getCurrentTextColor", "()I", ref global::android.widget.TextView._m94);
		}
		public new int HighlightColor
		{
			set
			{
				setHighlightColor(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m95;
		public virtual void setHighlightColor(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.TextView.staticClass, "setHighlightColor", "(I)V", ref global::android.widget.TextView._m95, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m96;
		public virtual void setShadowLayer(float arg0, float arg1, float arg2, int arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.TextView.staticClass, "setShadowLayer", "(FFFI)V", ref global::android.widget.TextView._m96, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		public new global::android.text.TextPaint Paint
		{
			get
			{
				return getPaint();
			}
		}
		private static global::MonoJavaBridge.MethodId _m97;
		public virtual global::android.text.TextPaint getPaint()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.widget.TextView.staticClass, "getPaint", "()Landroid/text/TextPaint;", ref global::android.widget.TextView._m97) as android.text.TextPaint;
		}
		private static global::MonoJavaBridge.MethodId _m98;
		public virtual void setAutoLinkMask(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.TextView.staticClass, "setAutoLinkMask", "(I)V", ref global::android.widget.TextView._m98, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m99;
		public virtual void setLinksClickable(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.TextView.staticClass, "setLinksClickable", "(Z)V", ref global::android.widget.TextView._m99, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		private static global::MonoJavaBridge.MethodId _m100;
		public virtual bool getLinksClickable()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.TextView.staticClass, "getLinksClickable", "()Z", ref global::android.widget.TextView._m100);
		}
		public new global::android.text.style.URLSpan[] Urls
		{
			get
			{
				return getUrls();
			}
		}
		private static global::MonoJavaBridge.MethodId _m101;
		public virtual global::android.text.style.URLSpan[] getUrls()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<android.text.style.URLSpan>(this, global::android.widget.TextView.staticClass, "getUrls", "()[Landroid/text/style/URLSpan;", ref global::android.widget.TextView._m101) as android.text.style.URLSpan[];
		}
		private static global::MonoJavaBridge.MethodId _m102;
		public virtual void setHintTextColor(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.TextView.staticClass, "setHintTextColor", "(I)V", ref global::android.widget.TextView._m102, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m103;
		public virtual void setHintTextColor(android.content.res.ColorStateList arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.TextView.staticClass, "setHintTextColor", "(Landroid/content/res/ColorStateList;)V", ref global::android.widget.TextView._m103, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::android.content.res.ColorStateList HintTextColors
		{
			get
			{
				return getHintTextColors();
			}
		}
		private static global::MonoJavaBridge.MethodId _m104;
		public virtual global::android.content.res.ColorStateList getHintTextColors()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.widget.TextView.staticClass, "getHintTextColors", "()Landroid/content/res/ColorStateList;", ref global::android.widget.TextView._m104) as android.content.res.ColorStateList;
		}
		public new int CurrentHintTextColor
		{
			get
			{
				return getCurrentHintTextColor();
			}
		}
		private static global::MonoJavaBridge.MethodId _m105;
		public virtual int getCurrentHintTextColor()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.widget.TextView.staticClass, "getCurrentHintTextColor", "()I", ref global::android.widget.TextView._m105);
		}
		private static global::MonoJavaBridge.MethodId _m106;
		public virtual void setLinkTextColor(android.content.res.ColorStateList arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.TextView.staticClass, "setLinkTextColor", "(Landroid/content/res/ColorStateList;)V", ref global::android.widget.TextView._m106, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m107;
		public virtual void setLinkTextColor(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.TextView.staticClass, "setLinkTextColor", "(I)V", ref global::android.widget.TextView._m107, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::android.content.res.ColorStateList LinkTextColors
		{
			get
			{
				return getLinkTextColors();
			}
		}
		private static global::MonoJavaBridge.MethodId _m108;
		public virtual global::android.content.res.ColorStateList getLinkTextColors()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.widget.TextView.staticClass, "getLinkTextColors", "()Landroid/content/res/ColorStateList;", ref global::android.widget.TextView._m108) as android.content.res.ColorStateList;
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
		private static global::MonoJavaBridge.MethodId _m109;
		public virtual int getGravity()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.widget.TextView.staticClass, "getGravity", "()I", ref global::android.widget.TextView._m109);
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
		private static global::MonoJavaBridge.MethodId _m110;
		public virtual int getPaintFlags()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.widget.TextView.staticClass, "getPaintFlags", "()I", ref global::android.widget.TextView._m110);
		}
		private static global::MonoJavaBridge.MethodId _m111;
		public virtual void setPaintFlags(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.TextView.staticClass, "setPaintFlags", "(I)V", ref global::android.widget.TextView._m111, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new bool HorizontallyScrolling
		{
			set
			{
				setHorizontallyScrolling(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m112;
		public virtual void setHorizontallyScrolling(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.TextView.staticClass, "setHorizontallyScrolling", "(Z)V", ref global::android.widget.TextView._m112, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int MinLines
		{
			set
			{
				setMinLines(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m113;
		public virtual void setMinLines(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.TextView.staticClass, "setMinLines", "(I)V", ref global::android.widget.TextView._m113, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int MinHeight
		{
			set
			{
				setMinHeight(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m114;
		public virtual void setMinHeight(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.TextView.staticClass, "setMinHeight", "(I)V", ref global::android.widget.TextView._m114, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int MaxLines
		{
			set
			{
				setMaxLines(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m115;
		public virtual void setMaxLines(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.TextView.staticClass, "setMaxLines", "(I)V", ref global::android.widget.TextView._m115, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int MaxHeight
		{
			set
			{
				setMaxHeight(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m116;
		public virtual void setMaxHeight(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.TextView.staticClass, "setMaxHeight", "(I)V", ref global::android.widget.TextView._m116, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int Lines
		{
			set
			{
				setLines(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m117;
		public virtual void setLines(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.TextView.staticClass, "setLines", "(I)V", ref global::android.widget.TextView._m117, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int Height
		{
			set
			{
				setHeight(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m118;
		public virtual void setHeight(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.TextView.staticClass, "setHeight", "(I)V", ref global::android.widget.TextView._m118, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int MinEms
		{
			set
			{
				setMinEms(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m119;
		public virtual void setMinEms(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.TextView.staticClass, "setMinEms", "(I)V", ref global::android.widget.TextView._m119, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int MinWidth
		{
			set
			{
				setMinWidth(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m120;
		public virtual void setMinWidth(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.TextView.staticClass, "setMinWidth", "(I)V", ref global::android.widget.TextView._m120, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int MaxEms
		{
			set
			{
				setMaxEms(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m121;
		public virtual void setMaxEms(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.TextView.staticClass, "setMaxEms", "(I)V", ref global::android.widget.TextView._m121, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int MaxWidth
		{
			set
			{
				setMaxWidth(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m122;
		public virtual void setMaxWidth(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.TextView.staticClass, "setMaxWidth", "(I)V", ref global::android.widget.TextView._m122, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int Ems
		{
			set
			{
				setEms(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m123;
		public virtual void setEms(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.TextView.staticClass, "setEms", "(I)V", ref global::android.widget.TextView._m123, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int Width
		{
			set
			{
				setWidth(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m124;
		public virtual void setWidth(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.TextView.staticClass, "setWidth", "(I)V", ref global::android.widget.TextView._m124, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m125;
		public virtual void setLineSpacing(float arg0, float arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.TextView.staticClass, "setLineSpacing", "(FF)V", ref global::android.widget.TextView._m125, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m126;
		public virtual void setFreezesText(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.TextView.staticClass, "setFreezesText", "(Z)V", ref global::android.widget.TextView._m126, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		private static global::MonoJavaBridge.MethodId _m127;
		public virtual bool getFreezesText()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.TextView.staticClass, "getFreezesText", "()Z", ref global::android.widget.TextView._m127);
		}
		public new global::android.text.Editable_Factory EditableFactory
		{
			set
			{
				setEditableFactory(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m128;
		public virtual void setEditableFactory(android.text.Editable_Factory arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.TextView.staticClass, "setEditableFactory", "(Landroid/text/Editable$Factory;)V", ref global::android.widget.TextView._m128, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::android.text.Spannable_Factory SpannableFactory
		{
			set
			{
				setSpannableFactory(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m129;
		public virtual void setSpannableFactory(android.text.Spannable_Factory arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.TextView.staticClass, "setSpannableFactory", "(Landroid/text/Spannable$Factory;)V", ref global::android.widget.TextView._m129, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m130;
		public virtual void setTextKeepState(java.lang.CharSequence arg0, android.widget.TextView.BufferType arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.TextView.staticClass, "setTextKeepState", "(Ljava/lang/CharSequence;Landroid/widget/TextView$BufferType;)V", ref global::android.widget.TextView._m130, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
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
		private static global::MonoJavaBridge.MethodId _m131;
		public virtual void setTextKeepState(java.lang.CharSequence arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.TextView.staticClass, "setTextKeepState", "(Ljava/lang/CharSequence;)V", ref global::android.widget.TextView._m131, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public void setTextKeepState(string arg0)
		{
			setTextKeepState((global::java.lang.CharSequence)(global::java.lang.String)arg0);
		}
		private static global::MonoJavaBridge.MethodId _m132;
		public virtual void setHint(java.lang.CharSequence arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.TextView.staticClass, "setHint", "(Ljava/lang/CharSequence;)V", ref global::android.widget.TextView._m132, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public void setHint(string arg0)
		{
			setHint((global::java.lang.CharSequence)(global::java.lang.String)arg0);
		}
		private static global::MonoJavaBridge.MethodId _m133;
		public virtual void setHint(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.TextView.staticClass, "setHint", "(I)V", ref global::android.widget.TextView._m133, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		private static global::MonoJavaBridge.MethodId _m134;
		public virtual global::java.lang.CharSequence getHint()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.lang.CharSequence>(this, global::android.widget.TextView.staticClass, "getHint", "()Ljava/lang/CharSequence;", ref global::android.widget.TextView._m134) as java.lang.CharSequence;
		}
		private static global::MonoJavaBridge.MethodId _m135;
		public virtual void setInputType(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.TextView.staticClass, "setInputType", "(I)V", ref global::android.widget.TextView._m135, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int RawInputType
		{
			set
			{
				setRawInputType(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m136;
		public virtual void setRawInputType(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.TextView.staticClass, "setRawInputType", "(I)V", ref global::android.widget.TextView._m136, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		private static global::MonoJavaBridge.MethodId _m137;
		public virtual int getInputType()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.widget.TextView.staticClass, "getInputType", "()I", ref global::android.widget.TextView._m137);
		}
		private static global::MonoJavaBridge.MethodId _m138;
		public virtual void setImeOptions(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.TextView.staticClass, "setImeOptions", "(I)V", ref global::android.widget.TextView._m138, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		private static global::MonoJavaBridge.MethodId _m139;
		public virtual int getImeOptions()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.widget.TextView.staticClass, "getImeOptions", "()I", ref global::android.widget.TextView._m139);
		}
		private static global::MonoJavaBridge.MethodId _m140;
		public virtual void setImeActionLabel(java.lang.CharSequence arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.TextView.staticClass, "setImeActionLabel", "(Ljava/lang/CharSequence;I)V", ref global::android.widget.TextView._m140, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
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
		private static global::MonoJavaBridge.MethodId _m141;
		public virtual global::java.lang.CharSequence getImeActionLabel()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.lang.CharSequence>(this, global::android.widget.TextView.staticClass, "getImeActionLabel", "()Ljava/lang/CharSequence;", ref global::android.widget.TextView._m141) as java.lang.CharSequence;
		}
		public new int ImeActionId
		{
			get
			{
				return getImeActionId();
			}
		}
		private static global::MonoJavaBridge.MethodId _m142;
		public virtual int getImeActionId()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.widget.TextView.staticClass, "getImeActionId", "()I", ref global::android.widget.TextView._m142);
		}
		private static global::MonoJavaBridge.MethodId _m143;
		public virtual void setOnEditorActionListener(android.widget.TextView.OnEditorActionListener arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.TextView.staticClass, "setOnEditorActionListener", "(Landroid/widget/TextView$OnEditorActionListener;)V", ref global::android.widget.TextView._m143, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public void setOnEditorActionListener(global::android.widget.TextView.OnEditorActionListenerDelegate arg0)
		{
			setOnEditorActionListener((global::android.widget.TextView.OnEditorActionListenerDelegateWrapper)arg0);
		}
		private static global::MonoJavaBridge.MethodId _m144;
		public virtual void onEditorAction(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.TextView.staticClass, "onEditorAction", "(I)V", ref global::android.widget.TextView._m144, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m145;
		public virtual void setPrivateImeOptions(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.TextView.staticClass, "setPrivateImeOptions", "(Ljava/lang/String;)V", ref global::android.widget.TextView._m145, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		private static global::MonoJavaBridge.MethodId _m146;
		public virtual global::java.lang.String getPrivateImeOptions()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.widget.TextView.staticClass, "getPrivateImeOptions", "()Ljava/lang/String;", ref global::android.widget.TextView._m146) as java.lang.String;
		}
		public new int InputExtras
		{
			set
			{
				setInputExtras(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m147;
		public virtual void setInputExtras(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.TextView.staticClass, "setInputExtras", "(I)V", ref global::android.widget.TextView._m147, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m148;
		public virtual global::android.os.Bundle getInputExtras(bool arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<android.os.Bundle>(this, global::android.widget.TextView.staticClass, "getInputExtras", "(Z)Landroid/os/Bundle;", ref global::android.widget.TextView._m148, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.os.Bundle;
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
		private static global::MonoJavaBridge.MethodId _m149;
		public virtual global::java.lang.CharSequence getError()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.lang.CharSequence>(this, global::android.widget.TextView.staticClass, "getError", "()Ljava/lang/CharSequence;", ref global::android.widget.TextView._m149) as java.lang.CharSequence;
		}
		private static global::MonoJavaBridge.MethodId _m150;
		protected virtual bool setFrame(int arg0, int arg1, int arg2, int arg3)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.TextView.staticClass, "setFrame", "(IIII)Z", ref global::android.widget.TextView._m150, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m151;
		public virtual void setFilters(android.text.InputFilter[] arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.TextView.staticClass, "setFilters", "([Landroid/text/InputFilter;)V", ref global::android.widget.TextView._m151, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		private static global::MonoJavaBridge.MethodId _m152;
		public virtual global::android.text.InputFilter[] getFilters()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<android.text.InputFilter>(this, global::android.widget.TextView.staticClass, "getFilters", "()[Landroid/text/InputFilter;", ref global::android.widget.TextView._m152) as android.text.InputFilter[];
		}
		private static global::MonoJavaBridge.MethodId _m153;
		public virtual bool onPreDraw()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.TextView.staticClass, "onPreDraw", "()Z", ref global::android.widget.TextView._m153);
		}
		public new int LineCount
		{
			get
			{
				return getLineCount();
			}
		}
		private static global::MonoJavaBridge.MethodId _m154;
		public virtual int getLineCount()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.widget.TextView.staticClass, "getLineCount", "()I", ref global::android.widget.TextView._m154);
		}
		private static global::MonoJavaBridge.MethodId _m155;
		public virtual int getLineBounds(int arg0, android.graphics.Rect arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.widget.TextView.staticClass, "getLineBounds", "(ILandroid/graphics/Rect;)I", ref global::android.widget.TextView._m155, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m156;
		public virtual bool extractText(android.view.inputmethod.ExtractedTextRequest arg0, android.view.inputmethod.ExtractedText arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.TextView.staticClass, "extractText", "(Landroid/view/inputmethod/ExtractedTextRequest;Landroid/view/inputmethod/ExtractedText;)Z", ref global::android.widget.TextView._m156, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public new global::android.view.inputmethod.ExtractedText ExtractedText
		{
			set
			{
				setExtractedText(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m157;
		public virtual void setExtractedText(android.view.inputmethod.ExtractedText arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.TextView.staticClass, "setExtractedText", "(Landroid/view/inputmethod/ExtractedText;)V", ref global::android.widget.TextView._m157, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m158;
		public virtual void onCommitCompletion(android.view.inputmethod.CompletionInfo arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.TextView.staticClass, "onCommitCompletion", "(Landroid/view/inputmethod/CompletionInfo;)V", ref global::android.widget.TextView._m158, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m159;
		public virtual void beginBatchEdit()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.TextView.staticClass, "beginBatchEdit", "()V", ref global::android.widget.TextView._m159);
		}
		private static global::MonoJavaBridge.MethodId _m160;
		public virtual void endBatchEdit()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.TextView.staticClass, "endBatchEdit", "()V", ref global::android.widget.TextView._m160);
		}
		private static global::MonoJavaBridge.MethodId _m161;
		public virtual void onBeginBatchEdit()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.TextView.staticClass, "onBeginBatchEdit", "()V", ref global::android.widget.TextView._m161);
		}
		private static global::MonoJavaBridge.MethodId _m162;
		public virtual void onEndBatchEdit()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.TextView.staticClass, "onEndBatchEdit", "()V", ref global::android.widget.TextView._m162);
		}
		private static global::MonoJavaBridge.MethodId _m163;
		public virtual bool onPrivateIMECommand(java.lang.String arg0, android.os.Bundle arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.TextView.staticClass, "onPrivateIMECommand", "(Ljava/lang/String;Landroid/os/Bundle;)Z", ref global::android.widget.TextView._m163, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public new bool IncludeFontPadding
		{
			set
			{
				setIncludeFontPadding(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m164;
		public virtual void setIncludeFontPadding(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.TextView.staticClass, "setIncludeFontPadding", "(Z)V", ref global::android.widget.TextView._m164, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m165;
		public virtual bool bringPointIntoView(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.TextView.staticClass, "bringPointIntoView", "(I)Z", ref global::android.widget.TextView._m165, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m166;
		public virtual bool moveCursorToVisibleOffset()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.TextView.staticClass, "moveCursorToVisibleOffset", "()Z", ref global::android.widget.TextView._m166);
		}
		public new int SelectionStart
		{
			get
			{
				return getSelectionStart();
			}
		}
		private static global::MonoJavaBridge.MethodId _m167;
		public virtual int getSelectionStart()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.widget.TextView.staticClass, "getSelectionStart", "()I", ref global::android.widget.TextView._m167);
		}
		public new int SelectionEnd
		{
			get
			{
				return getSelectionEnd();
			}
		}
		private static global::MonoJavaBridge.MethodId _m168;
		public virtual int getSelectionEnd()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.widget.TextView.staticClass, "getSelectionEnd", "()I", ref global::android.widget.TextView._m168);
		}
		private static global::MonoJavaBridge.MethodId _m169;
		public virtual bool hasSelection()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.TextView.staticClass, "hasSelection", "()Z", ref global::android.widget.TextView._m169);
		}
		private static global::MonoJavaBridge.MethodId _m170;
		public virtual void setSingleLine()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.TextView.staticClass, "setSingleLine", "()V", ref global::android.widget.TextView._m170);
		}
		public new bool SingleLine
		{
			set
			{
				setSingleLine(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m171;
		public virtual void setSingleLine(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.TextView.staticClass, "setSingleLine", "(Z)V", ref global::android.widget.TextView._m171, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m172;
		public virtual void setEllipsize(android.text.TextUtils.TruncateAt arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.TextView.staticClass, "setEllipsize", "(Landroid/text/TextUtils$TruncateAt;)V", ref global::android.widget.TextView._m172, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int MarqueeRepeatLimit
		{
			set
			{
				setMarqueeRepeatLimit(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m173;
		public virtual void setMarqueeRepeatLimit(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.TextView.staticClass, "setMarqueeRepeatLimit", "(I)V", ref global::android.widget.TextView._m173, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		private static global::MonoJavaBridge.MethodId _m174;
		public virtual global::android.text.TextUtils.TruncateAt getEllipsize()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<android.text.TextUtils.TruncateAt>(this, global::android.widget.TextView.staticClass, "getEllipsize", "()Landroid/text/TextUtils$TruncateAt;", ref global::android.widget.TextView._m174) as android.text.TextUtils.TruncateAt;
		}
		public new bool SelectAllOnFocus
		{
			set
			{
				setSelectAllOnFocus(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m175;
		public virtual void setSelectAllOnFocus(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.TextView.staticClass, "setSelectAllOnFocus", "(Z)V", ref global::android.widget.TextView._m175, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new bool CursorVisible
		{
			set
			{
				setCursorVisible(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m176;
		public virtual void setCursorVisible(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.TextView.staticClass, "setCursorVisible", "(Z)V", ref global::android.widget.TextView._m176, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m177;
		protected virtual void onTextChanged(java.lang.CharSequence arg0, int arg1, int arg2, int arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.TextView.staticClass, "onTextChanged", "(Ljava/lang/CharSequence;III)V", ref global::android.widget.TextView._m177, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		protected void onTextChanged(string arg0, int arg1, int arg2, int arg3)
		{
			onTextChanged((global::java.lang.CharSequence)(global::java.lang.String)arg0, arg1, arg2, arg3);
		}
		private static global::MonoJavaBridge.MethodId _m178;
		protected virtual void onSelectionChanged(int arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.TextView.staticClass, "onSelectionChanged", "(II)V", ref global::android.widget.TextView._m178, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m179;
		public virtual void addTextChangedListener(android.text.TextWatcher arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.TextView.staticClass, "addTextChangedListener", "(Landroid/text/TextWatcher;)V", ref global::android.widget.TextView._m179, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m180;
		public virtual void removeTextChangedListener(android.text.TextWatcher arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.TextView.staticClass, "removeTextChangedListener", "(Landroid/text/TextWatcher;)V", ref global::android.widget.TextView._m180, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m181;
		public virtual void clearComposingText()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.TextView.staticClass, "clearComposingText", "()V", ref global::android.widget.TextView._m181);
		}
		private static global::MonoJavaBridge.MethodId _m182;
		public virtual bool didTouchFocusSelect()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.TextView.staticClass, "didTouchFocusSelect", "()Z", ref global::android.widget.TextView._m182);
		}
		public new global::android.widget.Scroller Scroller
		{
			set
			{
				setScroller(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m183;
		public virtual void setScroller(android.widget.Scroller arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.TextView.staticClass, "setScroller", "(Landroid/widget/Scroller;)V", ref global::android.widget.TextView._m183, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m184;
		public static int getTextColor(android.content.Context arg0, android.content.res.TypedArray arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.TextView._m184.native == global::System.IntPtr.Zero)
				global::android.widget.TextView._m184 = @__env.GetStaticMethodIDNoThrow(global::android.widget.TextView.staticClass, "getTextColor", "(Landroid/content/Context;Landroid/content/res/TypedArray;I)I");
			return @__env.CallStaticIntMethod(android.widget.TextView.staticClass, global::android.widget.TextView._m184, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m185;
		public virtual bool isInputMethodTarget()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.TextView.staticClass, "isInputMethodTarget", "()Z", ref global::android.widget.TextView._m185);
		}
		private static global::MonoJavaBridge.MethodId _m186;
		public virtual bool onTextContextMenuItem(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.TextView.staticClass, "onTextContextMenuItem", "(I)Z", ref global::android.widget.TextView._m186, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m187;
		public TextView(android.content.Context arg0, android.util.AttributeSet arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.TextView._m187.native == global::System.IntPtr.Zero)
				global::android.widget.TextView._m187 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.TextView.staticClass, global::android.widget.TextView._m187, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m188;
		public TextView(android.content.Context arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.TextView._m188.native == global::System.IntPtr.Zero)
				global::android.widget.TextView._m188 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "<init>", "(Landroid/content/Context;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.TextView.staticClass, global::android.widget.TextView._m188, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m189;
		public TextView(android.content.Context arg0, android.util.AttributeSet arg1, int arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.TextView._m189.native == global::System.IntPtr.Zero)
				global::android.widget.TextView._m189 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.TextView.staticClass, global::android.widget.TextView._m189, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		static TextView()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.widget.TextView.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/TextView"));
		}
	}
}
