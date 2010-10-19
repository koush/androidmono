namespace android.widget
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class RadioGroup : android.widget.LinearLayout
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static RadioGroup()
		{
			InitJNI();
		}
		protected RadioGroup(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaClass()]
		public new partial class LayoutParams : android.widget.LinearLayout.LayoutParams
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static LayoutParams()
			{
				InitJNI();
			}
			protected LayoutParams(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _setBaseAttributes12263;
			protected override void setBaseAttributes(android.content.res.TypedArray arg0, int arg1, int arg2) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.widget.RadioGroup.LayoutParams._setBaseAttributes12263, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.RadioGroup.LayoutParams.staticClass, global::android.widget.RadioGroup.LayoutParams._setBaseAttributes12263, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			}
			internal static global::MonoJavaBridge.MethodId _LayoutParams12264;
			public LayoutParams(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.RadioGroup.LayoutParams.staticClass, global::android.widget.RadioGroup.LayoutParams._LayoutParams12264, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				Init(@__env, handle);
			}
			internal static global::MonoJavaBridge.MethodId _LayoutParams12265;
			public LayoutParams(int arg0, int arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.RadioGroup.LayoutParams.staticClass, global::android.widget.RadioGroup.LayoutParams._LayoutParams12265, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				Init(@__env, handle);
			}
			internal static global::MonoJavaBridge.MethodId _LayoutParams12266;
			public LayoutParams(int arg0, int arg1, float arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.RadioGroup.LayoutParams.staticClass, global::android.widget.RadioGroup.LayoutParams._LayoutParams12266, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
				Init(@__env, handle);
			}
			internal static global::MonoJavaBridge.MethodId _LayoutParams12267;
			public LayoutParams(android.view.ViewGroup.LayoutParams arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.RadioGroup.LayoutParams.staticClass, global::android.widget.RadioGroup.LayoutParams._LayoutParams12267, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				Init(@__env, handle);
			}
			internal static global::MonoJavaBridge.MethodId _LayoutParams12268;
			public LayoutParams(android.view.ViewGroup.MarginLayoutParams arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.RadioGroup.LayoutParams.staticClass, global::android.widget.RadioGroup.LayoutParams._LayoutParams12268, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				Init(@__env, handle);
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.widget.RadioGroup.LayoutParams.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/RadioGroup$LayoutParams"));
				global::android.widget.RadioGroup.LayoutParams._setBaseAttributes12263 = @__env.GetMethodIDNoThrow(global::android.widget.RadioGroup.LayoutParams.staticClass, "setBaseAttributes", "(Landroid/content/res/TypedArray;II)V");
				global::android.widget.RadioGroup.LayoutParams._LayoutParams12264 = @__env.GetMethodIDNoThrow(global::android.widget.RadioGroup.LayoutParams.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
				global::android.widget.RadioGroup.LayoutParams._LayoutParams12265 = @__env.GetMethodIDNoThrow(global::android.widget.RadioGroup.LayoutParams.staticClass, "<init>", "(II)V");
				global::android.widget.RadioGroup.LayoutParams._LayoutParams12266 = @__env.GetMethodIDNoThrow(global::android.widget.RadioGroup.LayoutParams.staticClass, "<init>", "(IIF)V");
				global::android.widget.RadioGroup.LayoutParams._LayoutParams12267 = @__env.GetMethodIDNoThrow(global::android.widget.RadioGroup.LayoutParams.staticClass, "<init>", "(Landroid/view/ViewGroup$LayoutParams;)V");
				global::android.widget.RadioGroup.LayoutParams._LayoutParams12268 = @__env.GetMethodIDNoThrow(global::android.widget.RadioGroup.LayoutParams.staticClass, "<init>", "(Landroid/view/ViewGroup$MarginLayoutParams;)V");
			}
		}
		[global::MonoJavaBridge.JavaInterface(typeof(global::android.widget.RadioGroup.OnCheckedChangeListener_))]
		public interface OnCheckedChangeListener  : global::MonoJavaBridge.IJavaObject 
		{
			void onCheckedChanged(android.widget.RadioGroup arg0, int arg1);
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.widget.RadioGroup.OnCheckedChangeListener))]
		public sealed partial class OnCheckedChangeListener_ : java.lang.Object, OnCheckedChangeListener
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static OnCheckedChangeListener_()
			{
				InitJNI();
			}
			internal OnCheckedChangeListener_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _onCheckedChanged12269;
			 void android.widget.RadioGroup.OnCheckedChangeListener.onCheckedChanged(android.widget.RadioGroup arg0, int arg1) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.widget.RadioGroup.OnCheckedChangeListener_._onCheckedChanged12269, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.RadioGroup.OnCheckedChangeListener_.staticClass, global::android.widget.RadioGroup.OnCheckedChangeListener_._onCheckedChanged12269, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.widget.RadioGroup.OnCheckedChangeListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/RadioGroup$OnCheckedChangeListener"));
				global::android.widget.RadioGroup.OnCheckedChangeListener_._onCheckedChanged12269 = @__env.GetMethodIDNoThrow(global::android.widget.RadioGroup.OnCheckedChangeListener_.staticClass, "onCheckedChanged", "(Landroid/widget/RadioGroup;I)V");
			}
		}
		internal static global::MonoJavaBridge.MethodId _check12270;
		public virtual void check(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.RadioGroup._check12270, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.RadioGroup.staticClass, global::android.widget.RadioGroup._check12270, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _addView12271;
		public override void addView(android.view.View arg0, int arg1, android.view.ViewGroup.LayoutParams arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.RadioGroup._addView12271, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.RadioGroup.staticClass, global::android.widget.RadioGroup._addView12271, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _onFinishInflate12272;
		protected override void onFinishInflate() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.RadioGroup._onFinishInflate12272);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.RadioGroup.staticClass, global::android.widget.RadioGroup._onFinishInflate12272);
		}
		internal static global::MonoJavaBridge.MethodId _checkLayoutParams12273;
		protected override bool checkLayoutParams(android.view.ViewGroup.LayoutParams arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.RadioGroup._checkLayoutParams12273, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.RadioGroup.staticClass, global::android.widget.RadioGroup._checkLayoutParams12273, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setOnHierarchyChangeListener12274;
		public override void setOnHierarchyChangeListener(android.view.ViewGroup.OnHierarchyChangeListener arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.RadioGroup._setOnHierarchyChangeListener12274, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.RadioGroup.staticClass, global::android.widget.RadioGroup._setOnHierarchyChangeListener12274, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _generateLayoutParams12275;
		public virtual global::android.widget.RadioGroup.LayoutParams generateLayoutParams(android.util.AttributeSet arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.RadioGroup._generateLayoutParams12275, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.widget.RadioGroup.LayoutParams;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.RadioGroup.staticClass, global::android.widget.RadioGroup._generateLayoutParams12275, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.widget.RadioGroup.LayoutParams;
		}
		internal static global::MonoJavaBridge.MethodId _generateDefaultLayoutParams12276;
		protected override global::android.widget.LinearLayout.LayoutParams generateDefaultLayoutParams() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.RadioGroup._generateDefaultLayoutParams12276)) as android.widget.LinearLayout.LayoutParams;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.RadioGroup.staticClass, global::android.widget.RadioGroup._generateDefaultLayoutParams12276)) as android.widget.LinearLayout.LayoutParams;
		}
		internal static global::MonoJavaBridge.MethodId _setOnCheckedChangeListener12277;
		public virtual void setOnCheckedChangeListener(android.widget.RadioGroup.OnCheckedChangeListener arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.RadioGroup._setOnCheckedChangeListener12277, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.RadioGroup.staticClass, global::android.widget.RadioGroup._setOnCheckedChangeListener12277, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int CheckedRadioButtonId
		{
			get
			{
				return getCheckedRadioButtonId();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getCheckedRadioButtonId12278;
		public virtual int getCheckedRadioButtonId() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.RadioGroup._getCheckedRadioButtonId12278);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.RadioGroup.staticClass, global::android.widget.RadioGroup._getCheckedRadioButtonId12278);
		}
		internal static global::MonoJavaBridge.MethodId _clearCheck12279;
		public virtual void clearCheck() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.RadioGroup._clearCheck12279);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.RadioGroup.staticClass, global::android.widget.RadioGroup._clearCheck12279);
		}
		internal static global::MonoJavaBridge.MethodId _RadioGroup12280;
		public RadioGroup(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.RadioGroup.staticClass, global::android.widget.RadioGroup._RadioGroup12280, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _RadioGroup12281;
		public RadioGroup(android.content.Context arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.RadioGroup.staticClass, global::android.widget.RadioGroup._RadioGroup12281, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.widget.RadioGroup.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/RadioGroup"));
			global::android.widget.RadioGroup._check12270 = @__env.GetMethodIDNoThrow(global::android.widget.RadioGroup.staticClass, "check", "(I)V");
			global::android.widget.RadioGroup._addView12271 = @__env.GetMethodIDNoThrow(global::android.widget.RadioGroup.staticClass, "addView", "(Landroid/view/View;ILandroid/view/ViewGroup$LayoutParams;)V");
			global::android.widget.RadioGroup._onFinishInflate12272 = @__env.GetMethodIDNoThrow(global::android.widget.RadioGroup.staticClass, "onFinishInflate", "()V");
			global::android.widget.RadioGroup._checkLayoutParams12273 = @__env.GetMethodIDNoThrow(global::android.widget.RadioGroup.staticClass, "checkLayoutParams", "(Landroid/view/ViewGroup$LayoutParams;)Z");
			global::android.widget.RadioGroup._setOnHierarchyChangeListener12274 = @__env.GetMethodIDNoThrow(global::android.widget.RadioGroup.staticClass, "setOnHierarchyChangeListener", "(Landroid/view/ViewGroup$OnHierarchyChangeListener;)V");
			global::android.widget.RadioGroup._generateLayoutParams12275 = @__env.GetMethodIDNoThrow(global::android.widget.RadioGroup.staticClass, "generateLayoutParams", "(Landroid/util/AttributeSet;)Landroid/widget/RadioGroup$LayoutParams;");
			global::android.widget.RadioGroup._generateDefaultLayoutParams12276 = @__env.GetMethodIDNoThrow(global::android.widget.RadioGroup.staticClass, "generateDefaultLayoutParams", "()Landroid/widget/LinearLayout$LayoutParams;");
			global::android.widget.RadioGroup._setOnCheckedChangeListener12277 = @__env.GetMethodIDNoThrow(global::android.widget.RadioGroup.staticClass, "setOnCheckedChangeListener", "(Landroid/widget/RadioGroup$OnCheckedChangeListener;)V");
			global::android.widget.RadioGroup._getCheckedRadioButtonId12278 = @__env.GetMethodIDNoThrow(global::android.widget.RadioGroup.staticClass, "getCheckedRadioButtonId", "()I");
			global::android.widget.RadioGroup._clearCheck12279 = @__env.GetMethodIDNoThrow(global::android.widget.RadioGroup.staticClass, "clearCheck", "()V");
			global::android.widget.RadioGroup._RadioGroup12280 = @__env.GetMethodIDNoThrow(global::android.widget.RadioGroup.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			global::android.widget.RadioGroup._RadioGroup12281 = @__env.GetMethodIDNoThrow(global::android.widget.RadioGroup.staticClass, "<init>", "(Landroid/content/Context;)V");
		}
	}
}
