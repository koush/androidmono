namespace android.text 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class DynamicLayout : android.text.Layout
	{ 
		internal new static global::java.lang.Class staticClass; 
		static DynamicLayout() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.text.DynamicLayout), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.text.DynamicLayout(@__env); 
			} 
		} 
		protected DynamicLayout(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getLineCount6442; 
		public override int getLineCount() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.DynamicLayout)) 
				return @__env.CallIntMethod(this, _getLineCount6442); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.text.DynamicLayout.staticClass, _getLineCount6442); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getEllipsizedWidth6443; 
		public override int getEllipsizedWidth() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.DynamicLayout)) 
				return @__env.CallIntMethod(this, _getEllipsizedWidth6443); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.text.DynamicLayout.staticClass, _getEllipsizedWidth6443); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getLineTop6444; 
		public override int getLineTop(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.DynamicLayout)) 
				return @__env.CallIntMethod(this, _getLineTop6444, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.text.DynamicLayout.staticClass, _getLineTop6444, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getLineDescent6445; 
		public override int getLineDescent(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.DynamicLayout)) 
				return @__env.CallIntMethod(this, _getLineDescent6445, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.text.DynamicLayout.staticClass, _getLineDescent6445, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getLineStart6446; 
		public override int getLineStart(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.DynamicLayout)) 
				return @__env.CallIntMethod(this, _getLineStart6446, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.text.DynamicLayout.staticClass, _getLineStart6446, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getParagraphDirection6447; 
		public override int getParagraphDirection(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.DynamicLayout)) 
				return @__env.CallIntMethod(this, _getParagraphDirection6447, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.text.DynamicLayout.staticClass, _getParagraphDirection6447, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getLineContainsTab6448; 
		public override bool getLineContainsTab(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.DynamicLayout)) 
				return @__env.CallBooleanMethod(this, _getLineContainsTab6448, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.text.DynamicLayout.staticClass, _getLineContainsTab6448, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getLineDirections6449; 
		public sealed override android.text.Layout.Directions getLineDirections(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.DynamicLayout)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.text.Layout.Directions>(@__env, @__env.CallObjectMethodPtr(this, _getLineDirections6449, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.text.Layout.Directions>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.text.DynamicLayout.staticClass, _getLineDirections6449, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getTopPadding6450; 
		public override int getTopPadding() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.DynamicLayout)) 
				return @__env.CallIntMethod(this, _getTopPadding6450); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.text.DynamicLayout.staticClass, _getTopPadding6450); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getBottomPadding6451; 
		public override int getBottomPadding() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.DynamicLayout)) 
				return @__env.CallIntMethod(this, _getBottomPadding6451); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.text.DynamicLayout.staticClass, _getBottomPadding6451); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getEllipsisStart6452; 
		public override int getEllipsisStart(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.DynamicLayout)) 
				return @__env.CallIntMethod(this, _getEllipsisStart6452, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.text.DynamicLayout.staticClass, _getEllipsisStart6452, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getEllipsisCount6453; 
		public override int getEllipsisCount(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.DynamicLayout)) 
				return @__env.CallIntMethod(this, _getEllipsisCount6453, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.text.DynamicLayout.staticClass, _getEllipsisCount6453, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _DynamicLayout6454; 
		public DynamicLayout(java.lang.CharSequence arg0, android.text.TextPaint arg1, int arg2, android.text.Layout.Alignment arg3, float arg4, float arg5, bool arg6)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.text.DynamicLayout.staticClass, _DynamicLayout6454, this, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg6)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _DynamicLayout6455; 
		public DynamicLayout(java.lang.CharSequence arg0, java.lang.CharSequence arg1, android.text.TextPaint arg2, int arg3, android.text.Layout.Alignment arg4, float arg5, float arg6, bool arg7)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.text.DynamicLayout.staticClass, _DynamicLayout6455, this, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg6), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg7)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _DynamicLayout6456; 
		public DynamicLayout(java.lang.CharSequence arg0, java.lang.CharSequence arg1, android.text.TextPaint arg2, int arg3, android.text.Layout.Alignment arg4, float arg5, float arg6, bool arg7, android.text.TextUtils.TruncateAt arg8, int arg9)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.text.DynamicLayout.staticClass, _DynamicLayout6456, this, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg6), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg7), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg8), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg9)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.text.DynamicLayout.staticClass = @__class; 
			global::android.text.DynamicLayout._getLineCount6442 = @__env.GetMethodID(global::android.text.DynamicLayout.staticClass, "getLineCount", "()I"); 
			global::android.text.DynamicLayout._getEllipsizedWidth6443 = @__env.GetMethodID(global::android.text.DynamicLayout.staticClass, "getEllipsizedWidth", "()I"); 
			global::android.text.DynamicLayout._getLineTop6444 = @__env.GetMethodID(global::android.text.DynamicLayout.staticClass, "getLineTop", "(I)I"); 
			global::android.text.DynamicLayout._getLineDescent6445 = @__env.GetMethodID(global::android.text.DynamicLayout.staticClass, "getLineDescent", "(I)I"); 
			global::android.text.DynamicLayout._getLineStart6446 = @__env.GetMethodID(global::android.text.DynamicLayout.staticClass, "getLineStart", "(I)I"); 
			global::android.text.DynamicLayout._getParagraphDirection6447 = @__env.GetMethodID(global::android.text.DynamicLayout.staticClass, "getParagraphDirection", "(I)I"); 
			global::android.text.DynamicLayout._getLineContainsTab6448 = @__env.GetMethodID(global::android.text.DynamicLayout.staticClass, "getLineContainsTab", "(I)Z"); 
			global::android.text.DynamicLayout._getLineDirections6449 = @__env.GetMethodID(global::android.text.DynamicLayout.staticClass, "getLineDirections", "(I)Landroid/text/Layout$Directions;"); 
			global::android.text.DynamicLayout._getTopPadding6450 = @__env.GetMethodID(global::android.text.DynamicLayout.staticClass, "getTopPadding", "()I"); 
			global::android.text.DynamicLayout._getBottomPadding6451 = @__env.GetMethodID(global::android.text.DynamicLayout.staticClass, "getBottomPadding", "()I"); 
			global::android.text.DynamicLayout._getEllipsisStart6452 = @__env.GetMethodID(global::android.text.DynamicLayout.staticClass, "getEllipsisStart", "(I)I"); 
			global::android.text.DynamicLayout._getEllipsisCount6453 = @__env.GetMethodID(global::android.text.DynamicLayout.staticClass, "getEllipsisCount", "(I)I"); 
			global::android.text.DynamicLayout._DynamicLayout6454 = @__env.GetMethodID(global::android.text.DynamicLayout.staticClass, "<init>", "(Ljava/lang/CharSequence;Landroid/text/TextPaint;ILandroid/text/Layout$Alignment;FFZ)V"); 
			global::android.text.DynamicLayout._DynamicLayout6455 = @__env.GetMethodID(global::android.text.DynamicLayout.staticClass, "<init>", "(Ljava/lang/CharSequence;Ljava/lang/CharSequence;Landroid/text/TextPaint;ILandroid/text/Layout$Alignment;FFZ)V"); 
			global::android.text.DynamicLayout._DynamicLayout6456 = @__env.GetMethodID(global::android.text.DynamicLayout.staticClass, "<init>", "(Ljava/lang/CharSequence;Ljava/lang/CharSequence;Landroid/text/TextPaint;ILandroid/text/Layout$Alignment;FFZLandroid/text/TextUtils$TruncateAt;I)V"); 
		} 
	} 
} 
