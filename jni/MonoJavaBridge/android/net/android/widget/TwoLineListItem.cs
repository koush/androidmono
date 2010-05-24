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
		internal static global::net.sf.jni4net.jni.MethodId _onFinishInflate11258; 
		protected override void onFinishInflate() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.TwoLineListItem)) 
				@__env.CallVoidMethod(this, _onFinishInflate11258); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.TwoLineListItem.staticClass, _onFinishInflate11258); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getText111259; 
		public virtual android.widget.TextView getText1() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.TwoLineListItem)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.widget.TextView>(@__env, @__env.CallObjectMethodPtr(this, _getText111259)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.widget.TextView>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.widget.TwoLineListItem.staticClass, _getText111259)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getText211260; 
		public virtual android.widget.TextView getText2() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.TwoLineListItem)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.widget.TextView>(@__env, @__env.CallObjectMethodPtr(this, _getText211260)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.widget.TextView>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.widget.TwoLineListItem.staticClass, _getText211260)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _TwoLineListItem11261; 
		public TwoLineListItem(android.content.Context arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.widget.TwoLineListItem.staticClass, _TwoLineListItem11261, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _TwoLineListItem11262; 
		public TwoLineListItem(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.widget.TwoLineListItem.staticClass, _TwoLineListItem11262, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _TwoLineListItem11263; 
		public TwoLineListItem(android.content.Context arg0, android.util.AttributeSet arg1, int arg2)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.widget.TwoLineListItem.staticClass, _TwoLineListItem11263, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.widget.TwoLineListItem.staticClass = @__class; 
			global::android.widget.TwoLineListItem._onFinishInflate11258 = @__env.GetMethodID(global::android.widget.TwoLineListItem.staticClass, "onFinishInflate", "()V"); 
			global::android.widget.TwoLineListItem._getText111259 = @__env.GetMethodID(global::android.widget.TwoLineListItem.staticClass, "getText1", "()Landroid/widget/TextView;"); 
			global::android.widget.TwoLineListItem._getText211260 = @__env.GetMethodID(global::android.widget.TwoLineListItem.staticClass, "getText2", "()Landroid/widget/TextView;"); 
			global::android.widget.TwoLineListItem._TwoLineListItem11261 = @__env.GetMethodID(global::android.widget.TwoLineListItem.staticClass, "<init>", "(Landroid/content/Context;)V"); 
			global::android.widget.TwoLineListItem._TwoLineListItem11262 = @__env.GetMethodID(global::android.widget.TwoLineListItem.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V"); 
			global::android.widget.TwoLineListItem._TwoLineListItem11263 = @__env.GetMethodID(global::android.widget.TwoLineListItem.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V"); 
		} 
	} 
} 
