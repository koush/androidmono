namespace android.widget
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class RadioGroup : android.widget.LinearLayout
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected RadioGroup(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaClass()]
		public new partial class LayoutParams : android.widget.LinearLayout.LayoutParams
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			protected LayoutParams(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			protected override void setBaseAttributes(android.content.res.TypedArray arg0, int arg1, int arg2)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.RadioGroup.LayoutParams.staticClass, "setBaseAttributes", "(Landroid/content/res/TypedArray;II)V", ref global::android.widget.RadioGroup.LayoutParams._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			}
			private static global::MonoJavaBridge.MethodId _m1;
			public LayoutParams(android.content.Context arg0, android.util.AttributeSet arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.widget.RadioGroup.LayoutParams._m1.native == global::System.IntPtr.Zero)
					global::android.widget.RadioGroup.LayoutParams._m1 = @__env.GetMethodIDNoThrow(global::android.widget.RadioGroup.LayoutParams.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.RadioGroup.LayoutParams.staticClass, global::android.widget.RadioGroup.LayoutParams._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				Init(@__env, handle);
			}
			private static global::MonoJavaBridge.MethodId _m2;
			public LayoutParams(int arg0, int arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.widget.RadioGroup.LayoutParams._m2.native == global::System.IntPtr.Zero)
					global::android.widget.RadioGroup.LayoutParams._m2 = @__env.GetMethodIDNoThrow(global::android.widget.RadioGroup.LayoutParams.staticClass, "<init>", "(II)V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.RadioGroup.LayoutParams.staticClass, global::android.widget.RadioGroup.LayoutParams._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				Init(@__env, handle);
			}
			private static global::MonoJavaBridge.MethodId _m3;
			public LayoutParams(int arg0, int arg1, float arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.widget.RadioGroup.LayoutParams._m3.native == global::System.IntPtr.Zero)
					global::android.widget.RadioGroup.LayoutParams._m3 = @__env.GetMethodIDNoThrow(global::android.widget.RadioGroup.LayoutParams.staticClass, "<init>", "(IIF)V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.RadioGroup.LayoutParams.staticClass, global::android.widget.RadioGroup.LayoutParams._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
				Init(@__env, handle);
			}
			private static global::MonoJavaBridge.MethodId _m4;
			public LayoutParams(android.view.ViewGroup.LayoutParams arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.widget.RadioGroup.LayoutParams._m4.native == global::System.IntPtr.Zero)
					global::android.widget.RadioGroup.LayoutParams._m4 = @__env.GetMethodIDNoThrow(global::android.widget.RadioGroup.LayoutParams.staticClass, "<init>", "(Landroid/view/ViewGroup$LayoutParams;)V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.RadioGroup.LayoutParams.staticClass, global::android.widget.RadioGroup.LayoutParams._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				Init(@__env, handle);
			}
			private static global::MonoJavaBridge.MethodId _m5;
			public LayoutParams(android.view.ViewGroup.MarginLayoutParams arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.widget.RadioGroup.LayoutParams._m5.native == global::System.IntPtr.Zero)
					global::android.widget.RadioGroup.LayoutParams._m5 = @__env.GetMethodIDNoThrow(global::android.widget.RadioGroup.LayoutParams.staticClass, "<init>", "(Landroid/view/ViewGroup$MarginLayoutParams;)V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.RadioGroup.LayoutParams.staticClass, global::android.widget.RadioGroup.LayoutParams._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				Init(@__env, handle);
			}
			static LayoutParams()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.widget.RadioGroup.LayoutParams.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/RadioGroup$LayoutParams"));
			}
		}
		[global::MonoJavaBridge.JavaInterface(typeof(global::android.widget.RadioGroup.OnCheckedChangeListener_))]
		public partial interface OnCheckedChangeListener  : global::MonoJavaBridge.IJavaObject 
		{
			void onCheckedChanged(android.widget.RadioGroup arg0, int arg1);
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.widget.RadioGroup.OnCheckedChangeListener))]
		internal sealed partial class OnCheckedChangeListener_ : java.lang.Object, OnCheckedChangeListener
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			internal OnCheckedChangeListener_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			void android.widget.RadioGroup.OnCheckedChangeListener.onCheckedChanged(android.widget.RadioGroup arg0, int arg1)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.RadioGroup.OnCheckedChangeListener_.staticClass, "onCheckedChanged", "(Landroid/widget/RadioGroup;I)V", ref global::android.widget.RadioGroup.OnCheckedChangeListener_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			static OnCheckedChangeListener_()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.widget.RadioGroup.OnCheckedChangeListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/RadioGroup$OnCheckedChangeListener"));
			}
		}

		public delegate void OnCheckedChangeListenerDelegate(android.widget.RadioGroup arg0, int arg1);

		internal partial class OnCheckedChangeListenerDelegateWrapper : java.lang.Object, OnCheckedChangeListener
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			protected OnCheckedChangeListenerDelegateWrapper(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			public OnCheckedChangeListenerDelegateWrapper() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.widget.RadioGroup.OnCheckedChangeListenerDelegateWrapper._m0.native == global::System.IntPtr.Zero)
					global::android.widget.RadioGroup.OnCheckedChangeListenerDelegateWrapper._m0 = @__env.GetMethodIDNoThrow(global::android.widget.RadioGroup.OnCheckedChangeListenerDelegateWrapper.staticClass, "<init>", "()V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.RadioGroup.OnCheckedChangeListenerDelegateWrapper.staticClass, global::android.widget.RadioGroup.OnCheckedChangeListenerDelegateWrapper._m0);
				Init(@__env, handle);
			}
			static OnCheckedChangeListenerDelegateWrapper()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.widget.RadioGroup.OnCheckedChangeListenerDelegateWrapper.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/RadioGroup_OnCheckedChangeListenerDelegateWrapper"));
			}
		}
		internal partial class OnCheckedChangeListenerDelegateWrapper
		{
			private OnCheckedChangeListenerDelegate myDelegate;
			public void onCheckedChanged(android.widget.RadioGroup arg0, int arg1)
			{
				myDelegate(arg0, arg1);
			}
			public static implicit operator OnCheckedChangeListenerDelegateWrapper(OnCheckedChangeListenerDelegate d)
			{
				global::android.widget.RadioGroup.OnCheckedChangeListenerDelegateWrapper ret = new global::android.widget.RadioGroup.OnCheckedChangeListenerDelegateWrapper();
				ret.myDelegate = d;
				global::MonoJavaBridge.JavaBridge.SetGCHandle(global::MonoJavaBridge.JNIEnv.ThreadEnv, ret);
				return ret;
			}
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual void check(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.RadioGroup.staticClass, "check", "(I)V", ref global::android.widget.RadioGroup._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override void addView(android.view.View arg0, int arg1, android.view.ViewGroup.LayoutParams arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.RadioGroup.staticClass, "addView", "(Landroid/view/View;ILandroid/view/ViewGroup$LayoutParams;)V", ref global::android.widget.RadioGroup._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		protected override void onFinishInflate()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.RadioGroup.staticClass, "onFinishInflate", "()V", ref global::android.widget.RadioGroup._m2);
		}
		private static global::MonoJavaBridge.MethodId _m3;
		protected override bool checkLayoutParams(android.view.ViewGroup.LayoutParams arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.RadioGroup.staticClass, "checkLayoutParams", "(Landroid/view/ViewGroup$LayoutParams;)Z", ref global::android.widget.RadioGroup._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::android.view.ViewGroup.OnHierarchyChangeListener OnHierarchyChangeListener
		{
			set
			{
				setOnHierarchyChangeListener(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public override void setOnHierarchyChangeListener(android.view.ViewGroup.OnHierarchyChangeListener arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.RadioGroup.staticClass, "setOnHierarchyChangeListener", "(Landroid/view/ViewGroup$OnHierarchyChangeListener;)V", ref global::android.widget.RadioGroup._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual global::android.widget.RadioGroup.LayoutParams generateLayoutParams(android.util.AttributeSet arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.widget.RadioGroup.staticClass, "generateLayoutParams", "(Landroid/util/AttributeSet;)Landroid/widget/RadioGroup$LayoutParams;", ref global::android.widget.RadioGroup._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.widget.RadioGroup.LayoutParams;
		}
		private static global::MonoJavaBridge.MethodId _m6;
		protected override global::android.widget.LinearLayout.LayoutParams generateDefaultLayoutParams()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.widget.RadioGroup.staticClass, "generateDefaultLayoutParams", "()Landroid/widget/LinearLayout$LayoutParams;", ref global::android.widget.RadioGroup._m6) as android.widget.LinearLayout.LayoutParams;
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public virtual void setOnCheckedChangeListener(android.widget.RadioGroup.OnCheckedChangeListener arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.RadioGroup.staticClass, "setOnCheckedChangeListener", "(Landroid/widget/RadioGroup$OnCheckedChangeListener;)V", ref global::android.widget.RadioGroup._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public void setOnCheckedChangeListener(global::android.widget.RadioGroup.OnCheckedChangeListenerDelegate arg0)
		{
			setOnCheckedChangeListener((global::android.widget.RadioGroup.OnCheckedChangeListenerDelegateWrapper)arg0);
		}
		public new int CheckedRadioButtonId
		{
			get
			{
				return getCheckedRadioButtonId();
			}
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public virtual int getCheckedRadioButtonId()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.widget.RadioGroup.staticClass, "getCheckedRadioButtonId", "()I", ref global::android.widget.RadioGroup._m8);
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public virtual void clearCheck()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.RadioGroup.staticClass, "clearCheck", "()V", ref global::android.widget.RadioGroup._m9);
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public RadioGroup(android.content.Context arg0, android.util.AttributeSet arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.RadioGroup._m10.native == global::System.IntPtr.Zero)
				global::android.widget.RadioGroup._m10 = @__env.GetMethodIDNoThrow(global::android.widget.RadioGroup.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.RadioGroup.staticClass, global::android.widget.RadioGroup._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public RadioGroup(android.content.Context arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.RadioGroup._m11.native == global::System.IntPtr.Zero)
				global::android.widget.RadioGroup._m11 = @__env.GetMethodIDNoThrow(global::android.widget.RadioGroup.staticClass, "<init>", "(Landroid/content/Context;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.RadioGroup.staticClass, global::android.widget.RadioGroup._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static RadioGroup()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.widget.RadioGroup.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/RadioGroup"));
		}
	}
}
