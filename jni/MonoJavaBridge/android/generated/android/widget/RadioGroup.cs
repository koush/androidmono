namespace android.widget
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class RadioGroup : android.widget.LinearLayout
	{
		internal new static global::java.lang.Class staticClass;
		static RadioGroup()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.widget.RadioGroup), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.widget.RadioGroup(@__env);
			}
		}
		protected RadioGroup(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		[global::net.sf.jni4net.attributes.JavaClassAttribute()]
		public new class LayoutParams : android.widget.LinearLayout.LayoutParams
		{
			internal new static global::java.lang.Class staticClass;
			static LayoutParams()
			{
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.widget.RadioGroup.LayoutParams), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
			}
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
			{
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
				{
					return new global::android.widget.RadioGroup.LayoutParams(@__env);
				}
			}
			protected LayoutParams(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::net.sf.jni4net.jni.MethodId _setBaseAttributes11338;
			protected override void setBaseAttributes(android.content.res.TypedArray arg0, int arg1, int arg2) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this, global::android.widget.RadioGroup.LayoutParams._setBaseAttributes11338, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
				else
					@__env.CallNonVirtualVoidMethod(this, global::android.widget.RadioGroup.LayoutParams.staticClass, global::android.widget.RadioGroup.LayoutParams._setBaseAttributes11338, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
			}
			internal static global::net.sf.jni4net.jni.MethodId _LayoutParams11339;
			public LayoutParams(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				@__env.NewObject(android.widget.RadioGroup.LayoutParams.staticClass, global::android.widget.RadioGroup.LayoutParams._LayoutParams11339, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1));
			}
			internal static global::net.sf.jni4net.jni.MethodId _LayoutParams11340;
			public LayoutParams(int arg0, int arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				@__env.NewObject(android.widget.RadioGroup.LayoutParams.staticClass, global::android.widget.RadioGroup.LayoutParams._LayoutParams11340, this, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			}
			internal static global::net.sf.jni4net.jni.MethodId _LayoutParams11341;
			public LayoutParams(int arg0, int arg1, float arg2)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				@__env.NewObject(android.widget.RadioGroup.LayoutParams.staticClass, global::android.widget.RadioGroup.LayoutParams._LayoutParams11341, this, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
			}
			internal static global::net.sf.jni4net.jni.MethodId _LayoutParams11342;
			public LayoutParams(android.view.ViewGroup.LayoutParams arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				@__env.NewObject(android.widget.RadioGroup.LayoutParams.staticClass, global::android.widget.RadioGroup.LayoutParams._LayoutParams11342, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			}
			internal static global::net.sf.jni4net.jni.MethodId _LayoutParams11343;
			public LayoutParams(android.view.ViewGroup.MarginLayoutParams arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				@__env.NewObject(android.widget.RadioGroup.LayoutParams.staticClass, global::android.widget.RadioGroup.LayoutParams._LayoutParams11343, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			}
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
			{
				global::android.widget.RadioGroup.LayoutParams.staticClass = @__class;
				global::android.widget.RadioGroup.LayoutParams._setBaseAttributes11338 = @__env.GetMethodID(global::android.widget.RadioGroup.LayoutParams.staticClass, "setBaseAttributes", "(Landroid/content/res/TypedArray;II)V");
				global::android.widget.RadioGroup.LayoutParams._LayoutParams11339 = @__env.GetMethodID(global::android.widget.RadioGroup.LayoutParams.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
				global::android.widget.RadioGroup.LayoutParams._LayoutParams11340 = @__env.GetMethodID(global::android.widget.RadioGroup.LayoutParams.staticClass, "<init>", "(II)V");
				global::android.widget.RadioGroup.LayoutParams._LayoutParams11341 = @__env.GetMethodID(global::android.widget.RadioGroup.LayoutParams.staticClass, "<init>", "(IIF)V");
				global::android.widget.RadioGroup.LayoutParams._LayoutParams11342 = @__env.GetMethodID(global::android.widget.RadioGroup.LayoutParams.staticClass, "<init>", "(Landroid/view/ViewGroup$LayoutParams;)V");
				global::android.widget.RadioGroup.LayoutParams._LayoutParams11343 = @__env.GetMethodID(global::android.widget.RadioGroup.LayoutParams.staticClass, "<init>", "(Landroid/view/ViewGroup$MarginLayoutParams;)V");
			}
		}
		[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()]
		public interface OnCheckedChangeListener 
		{
			void onCheckedChanged(android.widget.RadioGroup arg0, int arg1);
		}

		public partial class OnCheckedChangeListener_
		{
			public static global::java.lang.Class _class
			{
				get { return __OnCheckedChangeListener.staticClass; }
			}
		}

		[global::net.sf.jni4net.attributes.JavaClassAttribute()]
		public sealed class __OnCheckedChangeListener : java.lang.Object, OnCheckedChangeListener
		{
			internal static global::java.lang.Class staticClass;
			static __OnCheckedChangeListener()
			{
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.widget.RadioGroup.__OnCheckedChangeListener), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
			}
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
			{
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
				{
					return new global::android.widget.RadioGroup.__OnCheckedChangeListener(@__env);
				}
			}
			internal __OnCheckedChangeListener(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::net.sf.jni4net.jni.MethodId _onCheckedChanged11344;
			 void android.widget.RadioGroup.OnCheckedChangeListener.onCheckedChanged(android.widget.RadioGroup arg0, int arg1) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this, global::android.widget.RadioGroup.__OnCheckedChangeListener._onCheckedChanged11344, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
				else
					@__env.CallNonVirtualVoidMethod(this, global::android.widget.RadioGroup.__OnCheckedChangeListener.staticClass, global::android.widget.RadioGroup.__OnCheckedChangeListener._onCheckedChanged11344, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			}
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
			{
				global::android.widget.RadioGroup.__OnCheckedChangeListener.staticClass = @__class;
				global::android.widget.RadioGroup.__OnCheckedChangeListener._onCheckedChanged11344 = @__env.GetMethodID(global::android.widget.RadioGroup.__OnCheckedChangeListener.staticClass, "android.widget.RadioGroup.OnCheckedChangeListener.onCheckedChanged", "(Landroid/widget/RadioGroup;I)V");
			}
		}
		internal static global::net.sf.jni4net.jni.MethodId _check11345;
		public virtual void check(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.RadioGroup._check11345, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.RadioGroup.staticClass, global::android.widget.RadioGroup._check11345, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _addView11346;
		public override void addView(android.view.View arg0, int arg1, android.view.ViewGroup.LayoutParams arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.RadioGroup._addView11346, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.RadioGroup.staticClass, global::android.widget.RadioGroup._addView11346, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onFinishInflate11347;
		protected override void onFinishInflate() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.RadioGroup._onFinishInflate11347);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.RadioGroup.staticClass, global::android.widget.RadioGroup._onFinishInflate11347);
		}
		internal static global::net.sf.jni4net.jni.MethodId _checkLayoutParams11348;
		protected override bool checkLayoutParams(android.view.ViewGroup.LayoutParams arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.widget.RadioGroup._checkLayoutParams11348, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.RadioGroup.staticClass, global::android.widget.RadioGroup._checkLayoutParams11348, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setOnHierarchyChangeListener11349;
		public override void setOnHierarchyChangeListener(android.view.ViewGroup.OnHierarchyChangeListener arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.RadioGroup._setOnHierarchyChangeListener11349, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.RadioGroup.staticClass, global::android.widget.RadioGroup._setOnHierarchyChangeListener11349, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _generateLayoutParams11350;
		public virtual new global::android.widget.RadioGroup.LayoutParams generateLayoutParams(android.util.AttributeSet arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.widget.RadioGroup.LayoutParams>(@__env, @__env.CallObjectMethodPtr(this, global::android.widget.RadioGroup._generateLayoutParams11350, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.widget.RadioGroup.LayoutParams>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.widget.RadioGroup.staticClass, global::android.widget.RadioGroup._generateLayoutParams11350, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _generateDefaultLayoutParams11351;
		protected override global::android.widget.LinearLayout.LayoutParams generateDefaultLayoutParams() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.widget.LinearLayout.LayoutParams>(@__env, @__env.CallObjectMethodPtr(this, global::android.widget.RadioGroup._generateDefaultLayoutParams11351));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.widget.LinearLayout.LayoutParams>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.widget.RadioGroup.staticClass, global::android.widget.RadioGroup._generateDefaultLayoutParams11351));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setOnCheckedChangeListener11352;
		public virtual void setOnCheckedChangeListener(android.widget.RadioGroup.OnCheckedChangeListener arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.RadioGroup._setOnCheckedChangeListener11352, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.RadioGroup.staticClass, global::android.widget.RadioGroup._setOnCheckedChangeListener11352, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getCheckedRadioButtonId11353;
		public virtual int getCheckedRadioButtonId() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.widget.RadioGroup._getCheckedRadioButtonId11353);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.widget.RadioGroup.staticClass, global::android.widget.RadioGroup._getCheckedRadioButtonId11353);
		}
		internal static global::net.sf.jni4net.jni.MethodId _clearCheck11354;
		public virtual void clearCheck() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.RadioGroup._clearCheck11354);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.RadioGroup.staticClass, global::android.widget.RadioGroup._clearCheck11354);
		}
		internal static global::net.sf.jni4net.jni.MethodId _RadioGroup11355;
		public RadioGroup(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.widget.RadioGroup.staticClass, global::android.widget.RadioGroup._RadioGroup11355, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _RadioGroup11356;
		public RadioGroup(android.content.Context arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.widget.RadioGroup.staticClass, global::android.widget.RadioGroup._RadioGroup11356, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.widget.RadioGroup.staticClass = @__class;
			global::android.widget.RadioGroup._check11345 = @__env.GetMethodID(global::android.widget.RadioGroup.staticClass, "check", "(I)V");
			global::android.widget.RadioGroup._addView11346 = @__env.GetMethodID(global::android.widget.RadioGroup.staticClass, "addView", "(Landroid/view/View;ILandroid/view/ViewGroup$LayoutParams;)V");
			global::android.widget.RadioGroup._onFinishInflate11347 = @__env.GetMethodID(global::android.widget.RadioGroup.staticClass, "onFinishInflate", "()V");
			global::android.widget.RadioGroup._checkLayoutParams11348 = @__env.GetMethodID(global::android.widget.RadioGroup.staticClass, "checkLayoutParams", "(Landroid/view/ViewGroup$LayoutParams;)Z");
			global::android.widget.RadioGroup._setOnHierarchyChangeListener11349 = @__env.GetMethodID(global::android.widget.RadioGroup.staticClass, "setOnHierarchyChangeListener", "(Landroid/view/ViewGroup$OnHierarchyChangeListener;)V");
			global::android.widget.RadioGroup._generateLayoutParams11350 = @__env.GetMethodID(global::android.widget.RadioGroup.staticClass, "generateLayoutParams", "(Landroid/util/AttributeSet;)Landroid/widget/RadioGroup$LayoutParams;");
			global::android.widget.RadioGroup._generateDefaultLayoutParams11351 = @__env.GetMethodID(global::android.widget.RadioGroup.staticClass, "generateDefaultLayoutParams", "()Landroid/widget/LinearLayout$LayoutParams;");
			global::android.widget.RadioGroup._setOnCheckedChangeListener11352 = @__env.GetMethodID(global::android.widget.RadioGroup.staticClass, "setOnCheckedChangeListener", "(Landroid/widget/RadioGroup$OnCheckedChangeListener;)V");
			global::android.widget.RadioGroup._getCheckedRadioButtonId11353 = @__env.GetMethodID(global::android.widget.RadioGroup.staticClass, "getCheckedRadioButtonId", "()I");
			global::android.widget.RadioGroup._clearCheck11354 = @__env.GetMethodID(global::android.widget.RadioGroup.staticClass, "clearCheck", "()V");
			global::android.widget.RadioGroup._RadioGroup11355 = @__env.GetMethodID(global::android.widget.RadioGroup.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			global::android.widget.RadioGroup._RadioGroup11356 = @__env.GetMethodID(global::android.widget.RadioGroup.staticClass, "<init>", "(Landroid/content/Context;)V");
		}
	}
}
