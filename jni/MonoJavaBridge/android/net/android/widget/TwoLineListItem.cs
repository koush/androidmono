namespace android.widget 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class TwoLineListItem : android.widget.RelativeLayout
	{ 
		internal new static global::java.lang.Class staticClass; 
		static TwoLineListItem() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.widget.TwoLineListItem), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.widget.TwoLineListItem(@__env); 
			} 
		} 
		protected TwoLineListItem(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onFinishInflate10453; 
		protected override void onFinishInflate() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.TwoLineListItem)) 
				@__env.CallVoidMethod(this, _onFinishInflate10453); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.TwoLineListItem.staticClass, _onFinishInflate10453); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getText110454; 
		public virtual android.widget.TextView getText1() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.TwoLineListItem)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.widget.TextView>(@__env, @__env.CallObjectMethodPtr(this, _getText110454)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.widget.TextView>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.widget.TwoLineListItem.staticClass, _getText110454)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getText210455; 
		public virtual android.widget.TextView getText2() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.TwoLineListItem)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.widget.TextView>(@__env, @__env.CallObjectMethodPtr(this, _getText210455)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.widget.TextView>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.widget.TwoLineListItem.staticClass, _getText210455)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _TwoLineListItem10456; 
		public TwoLineListItem(android.content.Context arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.widget.TwoLineListItem.staticClass, _TwoLineListItem10456, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _TwoLineListItem10457; 
		public TwoLineListItem(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.widget.TwoLineListItem.staticClass, _TwoLineListItem10457, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _TwoLineListItem10458; 
		public TwoLineListItem(android.content.Context arg0, android.util.AttributeSet arg1, int arg2)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.widget.TwoLineListItem.staticClass, _TwoLineListItem10458, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.widget.TwoLineListItem.staticClass = @__class; 
			global::android.widget.TwoLineListItem._onFinishInflate10453 = @__env.GetMethodID(global::android.widget.TwoLineListItem.staticClass, "onFinishInflate", "()V"); 
			global::android.widget.TwoLineListItem._getText110454 = @__env.GetMethodID(global::android.widget.TwoLineListItem.staticClass, "getText1", "()Landroid/widget/TextView;"); 
			global::android.widget.TwoLineListItem._getText210455 = @__env.GetMethodID(global::android.widget.TwoLineListItem.staticClass, "getText2", "()Landroid/widget/TextView;"); 
			global::android.widget.TwoLineListItem._TwoLineListItem10456 = @__env.GetMethodID(global::android.widget.TwoLineListItem.staticClass, "<init>", "(Landroid/content/Context;)V"); 
			global::android.widget.TwoLineListItem._TwoLineListItem10457 = @__env.GetMethodID(global::android.widget.TwoLineListItem.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V"); 
			global::android.widget.TwoLineListItem._TwoLineListItem10458 = @__env.GetMethodID(global::android.widget.TwoLineListItem.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V"); 
		} 
	} 
} 
