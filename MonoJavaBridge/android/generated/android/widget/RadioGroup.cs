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
			internal static global::MonoJavaBridge.MethodId _setBaseAttributes17536;
			protected override void setBaseAttributes(android.content.res.TypedArray arg0, int arg1, int arg2)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.RadioGroup.LayoutParams.staticClass, "setBaseAttributes", "(Landroid/content/res/TypedArray;II)V", ref global::android.widget.RadioGroup.LayoutParams._setBaseAttributes17536, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			}
			internal static global::MonoJavaBridge.MethodId _LayoutParams17537;
			public LayoutParams(android.content.Context arg0, android.util.AttributeSet arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.widget.RadioGroup.LayoutParams._LayoutParams17537.native == global::System.IntPtr.Zero)
					global::android.widget.RadioGroup.LayoutParams._LayoutParams17537 = @__env.GetMethodIDNoThrow(global::android.widget.RadioGroup.LayoutParams.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.RadioGroup.LayoutParams.staticClass, global::android.widget.RadioGroup.LayoutParams._LayoutParams17537, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				Init(@__env, handle);
			}
			internal static global::MonoJavaBridge.MethodId _LayoutParams17538;
			public LayoutParams(int arg0, int arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.widget.RadioGroup.LayoutParams._LayoutParams17538.native == global::System.IntPtr.Zero)
					global::android.widget.RadioGroup.LayoutParams._LayoutParams17538 = @__env.GetMethodIDNoThrow(global::android.widget.RadioGroup.LayoutParams.staticClass, "<init>", "(II)V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.RadioGroup.LayoutParams.staticClass, global::android.widget.RadioGroup.LayoutParams._LayoutParams17538, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				Init(@__env, handle);
			}
			internal static global::MonoJavaBridge.MethodId _LayoutParams17539;
			public LayoutParams(int arg0, int arg1, float arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.widget.RadioGroup.LayoutParams._LayoutParams17539.native == global::System.IntPtr.Zero)
					global::android.widget.RadioGroup.LayoutParams._LayoutParams17539 = @__env.GetMethodIDNoThrow(global::android.widget.RadioGroup.LayoutParams.staticClass, "<init>", "(IIF)V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.RadioGroup.LayoutParams.staticClass, global::android.widget.RadioGroup.LayoutParams._LayoutParams17539, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
				Init(@__env, handle);
			}
			internal static global::MonoJavaBridge.MethodId _LayoutParams17540;
			public LayoutParams(android.view.ViewGroup.LayoutParams arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.widget.RadioGroup.LayoutParams._LayoutParams17540.native == global::System.IntPtr.Zero)
					global::android.widget.RadioGroup.LayoutParams._LayoutParams17540 = @__env.GetMethodIDNoThrow(global::android.widget.RadioGroup.LayoutParams.staticClass, "<init>", "(Landroid/view/ViewGroup$LayoutParams;)V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.RadioGroup.LayoutParams.staticClass, global::android.widget.RadioGroup.LayoutParams._LayoutParams17540, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				Init(@__env, handle);
			}
			internal static global::MonoJavaBridge.MethodId _LayoutParams17541;
			public LayoutParams(android.view.ViewGroup.MarginLayoutParams arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.widget.RadioGroup.LayoutParams._LayoutParams17541.native == global::System.IntPtr.Zero)
					global::android.widget.RadioGroup.LayoutParams._LayoutParams17541 = @__env.GetMethodIDNoThrow(global::android.widget.RadioGroup.LayoutParams.staticClass, "<init>", "(Landroid/view/ViewGroup$MarginLayoutParams;)V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.RadioGroup.LayoutParams.staticClass, global::android.widget.RadioGroup.LayoutParams._LayoutParams17541, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				Init(@__env, handle);
			}
			static LayoutParams()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.widget.RadioGroup.LayoutParams.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/RadioGroup$LayoutParams"));
			}
			internal static void InitJNI()
			{
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
			internal static global::MonoJavaBridge.MethodId _onCheckedChanged17542;
			void android.widget.RadioGroup.OnCheckedChangeListener.onCheckedChanged(android.widget.RadioGroup arg0, int arg1)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.RadioGroup.OnCheckedChangeListener_.staticClass, "onCheckedChanged", "(Landroid/widget/RadioGroup;I)V", ref global::android.widget.RadioGroup.OnCheckedChangeListener_._onCheckedChanged17542, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			static OnCheckedChangeListener_()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.widget.RadioGroup.OnCheckedChangeListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/RadioGroup$OnCheckedChangeListener"));
			}
			internal static void InitJNI()
			{
			}
		}

		public delegate void OnCheckedChangeListenerDelegate(android.widget.RadioGroup arg0, int arg1);

		internal partial class OnCheckedChangeListenerDelegateWrapper : java.lang.Object, OnCheckedChangeListener
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			protected OnCheckedChangeListenerDelegateWrapper(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _OnCheckedChangeListenerDelegateWrapper17543;
			public OnCheckedChangeListenerDelegateWrapper() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.widget.RadioGroup.OnCheckedChangeListenerDelegateWrapper._OnCheckedChangeListenerDelegateWrapper17543.native == global::System.IntPtr.Zero)
					global::android.widget.RadioGroup.OnCheckedChangeListenerDelegateWrapper._OnCheckedChangeListenerDelegateWrapper17543 = @__env.GetMethodIDNoThrow(global::android.widget.RadioGroup.OnCheckedChangeListenerDelegateWrapper.staticClass, "<init>", "()V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.RadioGroup.OnCheckedChangeListenerDelegateWrapper.staticClass, global::android.widget.RadioGroup.OnCheckedChangeListenerDelegateWrapper._OnCheckedChangeListenerDelegateWrapper17543);
				Init(@__env, handle);
			}
			static OnCheckedChangeListenerDelegateWrapper()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.widget.RadioGroup.OnCheckedChangeListenerDelegateWrapper.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/RadioGroup_OnCheckedChangeListenerDelegateWrapper"));
			}
			internal static void InitJNI()
			{
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
		internal static global::MonoJavaBridge.MethodId _check17544;
		public virtual void check(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.RadioGroup.staticClass, "check", "(I)V", ref global::android.widget.RadioGroup._check17544, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _addView17545;
		public override void addView(android.view.View arg0, int arg1, android.view.ViewGroup.LayoutParams arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.RadioGroup.staticClass, "addView", "(Landroid/view/View;ILandroid/view/ViewGroup$LayoutParams;)V", ref global::android.widget.RadioGroup._addView17545, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _onFinishInflate17546;
		protected override void onFinishInflate()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.RadioGroup.staticClass, "onFinishInflate", "()V", ref global::android.widget.RadioGroup._onFinishInflate17546);
		}
		internal static global::MonoJavaBridge.MethodId _checkLayoutParams17547;
		protected override bool checkLayoutParams(android.view.ViewGroup.LayoutParams arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.RadioGroup.staticClass, "checkLayoutParams", "(Landroid/view/ViewGroup$LayoutParams;)Z", ref global::android.widget.RadioGroup._checkLayoutParams17547, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::android.view.ViewGroup.OnHierarchyChangeListener OnHierarchyChangeListener
		{
			set
			{
				setOnHierarchyChangeListener(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setOnHierarchyChangeListener17548;
		public override void setOnHierarchyChangeListener(android.view.ViewGroup.OnHierarchyChangeListener arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.RadioGroup.staticClass, "setOnHierarchyChangeListener", "(Landroid/view/ViewGroup$OnHierarchyChangeListener;)V", ref global::android.widget.RadioGroup._setOnHierarchyChangeListener17548, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _generateLayoutParams17549;
		public virtual global::android.widget.RadioGroup.LayoutParams generateLayoutParams(android.util.AttributeSet arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.widget.RadioGroup.staticClass, "generateLayoutParams", "(Landroid/util/AttributeSet;)Landroid/widget/RadioGroup$LayoutParams;", ref global::android.widget.RadioGroup._generateLayoutParams17549, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.widget.RadioGroup.LayoutParams;
		}
		internal static global::MonoJavaBridge.MethodId _generateDefaultLayoutParams17550;
		protected override global::android.widget.LinearLayout.LayoutParams generateDefaultLayoutParams()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.widget.RadioGroup.staticClass, "generateDefaultLayoutParams", "()Landroid/widget/LinearLayout$LayoutParams;", ref global::android.widget.RadioGroup._generateDefaultLayoutParams17550) as android.widget.LinearLayout.LayoutParams;
		}
		internal static global::MonoJavaBridge.MethodId _setOnCheckedChangeListener17551;
		public virtual void setOnCheckedChangeListener(android.widget.RadioGroup.OnCheckedChangeListener arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.RadioGroup.staticClass, "setOnCheckedChangeListener", "(Landroid/widget/RadioGroup$OnCheckedChangeListener;)V", ref global::android.widget.RadioGroup._setOnCheckedChangeListener17551, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getCheckedRadioButtonId17552;
		public virtual int getCheckedRadioButtonId()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.widget.RadioGroup.staticClass, "getCheckedRadioButtonId", "()I", ref global::android.widget.RadioGroup._getCheckedRadioButtonId17552);
		}
		internal static global::MonoJavaBridge.MethodId _clearCheck17553;
		public virtual void clearCheck()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.RadioGroup.staticClass, "clearCheck", "()V", ref global::android.widget.RadioGroup._clearCheck17553);
		}
		internal static global::MonoJavaBridge.MethodId _RadioGroup17554;
		public RadioGroup(android.content.Context arg0, android.util.AttributeSet arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.RadioGroup._RadioGroup17554.native == global::System.IntPtr.Zero)
				global::android.widget.RadioGroup._RadioGroup17554 = @__env.GetMethodIDNoThrow(global::android.widget.RadioGroup.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.RadioGroup.staticClass, global::android.widget.RadioGroup._RadioGroup17554, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _RadioGroup17555;
		public RadioGroup(android.content.Context arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.RadioGroup._RadioGroup17555.native == global::System.IntPtr.Zero)
				global::android.widget.RadioGroup._RadioGroup17555 = @__env.GetMethodIDNoThrow(global::android.widget.RadioGroup.staticClass, "<init>", "(Landroid/content/Context;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.RadioGroup.staticClass, global::android.widget.RadioGroup._RadioGroup17555, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static RadioGroup()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.widget.RadioGroup.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/RadioGroup"));
		}
		internal static void InitJNI()
		{
		}
	}
}
