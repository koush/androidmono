namespace android.text.style 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class LeadingMarginSpan_Standard : java.lang.Object, LeadingMarginSpan, ParcelableSpan
	{ 
		internal static global::java.lang.Class staticClass; 
		static LeadingMarginSpan_Standard() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.text.style.LeadingMarginSpan_Standard), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.text.style.LeadingMarginSpan_Standard(@__env); 
			} 
		} 
		protected LeadingMarginSpan_Standard(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _writeToParcel6983; 
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.style.LeadingMarginSpan_Standard)) 
				@__env.CallVoidMethod(this, _writeToParcel6983, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.text.style.LeadingMarginSpan_Standard.staticClass, _writeToParcel6983, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _describeContents6984; 
		public virtual int describeContents() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.style.LeadingMarginSpan_Standard)) 
				return @__env.CallIntMethod(this, _describeContents6984); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.text.style.LeadingMarginSpan_Standard.staticClass, _describeContents6984); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getSpanTypeId6985; 
		public virtual int getSpanTypeId() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.style.LeadingMarginSpan_Standard)) 
				return @__env.CallIntMethod(this, _getSpanTypeId6985); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.text.style.LeadingMarginSpan_Standard.staticClass, _getSpanTypeId6985); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getLeadingMargin6986; 
		public virtual int getLeadingMargin(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.style.LeadingMarginSpan_Standard)) 
				return @__env.CallIntMethod(this, _getLeadingMargin6986, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.text.style.LeadingMarginSpan_Standard.staticClass, _getLeadingMargin6986, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _drawLeadingMargin6987; 
		public virtual void drawLeadingMargin(android.graphics.Canvas arg0, android.graphics.Paint arg1, int arg2, int arg3, int arg4, int arg5, int arg6, java.lang.CharSequence arg7, int arg8, int arg9, bool arg10, android.text.Layout arg11) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.style.LeadingMarginSpan_Standard)) 
				@__env.CallVoidMethod(this, _drawLeadingMargin6987, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg6), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg7), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg8), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg9), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg10), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg11)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.text.style.LeadingMarginSpan_Standard.staticClass, _drawLeadingMargin6987, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg6), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg7), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg8), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg9), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg10), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg11)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _LeadingMarginSpan_Standard6988; 
		public LeadingMarginSpan_Standard(int arg0, int arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.text.style.LeadingMarginSpan_Standard.staticClass, _LeadingMarginSpan_Standard6988, this, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _LeadingMarginSpan_Standard6989; 
		public LeadingMarginSpan_Standard(int arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.text.style.LeadingMarginSpan_Standard.staticClass, _LeadingMarginSpan_Standard6989, this, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _LeadingMarginSpan_Standard6990; 
		public LeadingMarginSpan_Standard(android.os.Parcel arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.text.style.LeadingMarginSpan_Standard.staticClass, _LeadingMarginSpan_Standard6990, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.text.style.LeadingMarginSpan_Standard.staticClass = @__class; 
			global::android.text.style.LeadingMarginSpan_Standard._writeToParcel6983 = @__env.GetMethodID(global::android.text.style.LeadingMarginSpan_Standard.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V"); 
			global::android.text.style.LeadingMarginSpan_Standard._describeContents6984 = @__env.GetMethodID(global::android.text.style.LeadingMarginSpan_Standard.staticClass, "describeContents", "()I"); 
			global::android.text.style.LeadingMarginSpan_Standard._getSpanTypeId6985 = @__env.GetMethodID(global::android.text.style.LeadingMarginSpan_Standard.staticClass, "getSpanTypeId", "()I"); 
			global::android.text.style.LeadingMarginSpan_Standard._getLeadingMargin6986 = @__env.GetMethodID(global::android.text.style.LeadingMarginSpan_Standard.staticClass, "getLeadingMargin", "(Z)I"); 
			global::android.text.style.LeadingMarginSpan_Standard._drawLeadingMargin6987 = @__env.GetMethodID(global::android.text.style.LeadingMarginSpan_Standard.staticClass, "drawLeadingMargin", "(Landroid/graphics/Canvas;Landroid/graphics/Paint;IIIIILjava/lang/CharSequence;IIZLandroid/text/Layout;)V"); 
			global::android.text.style.LeadingMarginSpan_Standard._LeadingMarginSpan_Standard6988 = @__env.GetMethodID(global::android.text.style.LeadingMarginSpan_Standard.staticClass, "<init>", "(II)V"); 
			global::android.text.style.LeadingMarginSpan_Standard._LeadingMarginSpan_Standard6989 = @__env.GetMethodID(global::android.text.style.LeadingMarginSpan_Standard.staticClass, "<init>", "(I)V"); 
			global::android.text.style.LeadingMarginSpan_Standard._LeadingMarginSpan_Standard6990 = @__env.GetMethodID(global::android.text.style.LeadingMarginSpan_Standard.staticClass, "<init>", "(Landroid/os/Parcel;)V"); 
		} 
	} 
} 
