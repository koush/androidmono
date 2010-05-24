namespace android.text.style 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class AbsoluteSizeSpan : android.text.style.MetricAffectingSpan, ParcelableSpan
	{ 
		internal new static global::java.lang.Class staticClass; 
		static AbsoluteSizeSpan() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.text.style.AbsoluteSizeSpan), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.text.style.AbsoluteSizeSpan(@__env); 
			} 
		} 
		protected AbsoluteSizeSpan(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getSize7277; 
		public virtual int getSize() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.style.AbsoluteSizeSpan)) 
				return @__env.CallIntMethod(this, _getSize7277); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.text.style.AbsoluteSizeSpan.staticClass, _getSize7277); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _writeToParcel7278; 
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.style.AbsoluteSizeSpan)) 
				@__env.CallVoidMethod(this, _writeToParcel7278, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.text.style.AbsoluteSizeSpan.staticClass, _writeToParcel7278, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _describeContents7279; 
		public virtual int describeContents() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.style.AbsoluteSizeSpan)) 
				return @__env.CallIntMethod(this, _describeContents7279); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.text.style.AbsoluteSizeSpan.staticClass, _describeContents7279); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getSpanTypeId7280; 
		public virtual int getSpanTypeId() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.style.AbsoluteSizeSpan)) 
				return @__env.CallIntMethod(this, _getSpanTypeId7280); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.text.style.AbsoluteSizeSpan.staticClass, _getSpanTypeId7280); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _updateDrawState7281; 
		public override void updateDrawState(android.text.TextPaint arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.style.AbsoluteSizeSpan)) 
				@__env.CallVoidMethod(this, _updateDrawState7281, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.text.style.AbsoluteSizeSpan.staticClass, _updateDrawState7281, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getDip7282; 
		public virtual bool getDip() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.style.AbsoluteSizeSpan)) 
				return @__env.CallBooleanMethod(this, _getDip7282); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.text.style.AbsoluteSizeSpan.staticClass, _getDip7282); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _updateMeasureState7283; 
		public override void updateMeasureState(android.text.TextPaint arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.style.AbsoluteSizeSpan)) 
				@__env.CallVoidMethod(this, _updateMeasureState7283, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.text.style.AbsoluteSizeSpan.staticClass, _updateMeasureState7283, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _AbsoluteSizeSpan7284; 
		public AbsoluteSizeSpan(int arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.text.style.AbsoluteSizeSpan.staticClass, _AbsoluteSizeSpan7284, this, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _AbsoluteSizeSpan7285; 
		public AbsoluteSizeSpan(int arg0, bool arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.text.style.AbsoluteSizeSpan.staticClass, _AbsoluteSizeSpan7285, this, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _AbsoluteSizeSpan7286; 
		public AbsoluteSizeSpan(android.os.Parcel arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.text.style.AbsoluteSizeSpan.staticClass, _AbsoluteSizeSpan7286, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.text.style.AbsoluteSizeSpan.staticClass = @__class; 
			global::android.text.style.AbsoluteSizeSpan._getSize7277 = @__env.GetMethodID(global::android.text.style.AbsoluteSizeSpan.staticClass, "getSize", "()I"); 
			global::android.text.style.AbsoluteSizeSpan._writeToParcel7278 = @__env.GetMethodID(global::android.text.style.AbsoluteSizeSpan.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V"); 
			global::android.text.style.AbsoluteSizeSpan._describeContents7279 = @__env.GetMethodID(global::android.text.style.AbsoluteSizeSpan.staticClass, "describeContents", "()I"); 
			global::android.text.style.AbsoluteSizeSpan._getSpanTypeId7280 = @__env.GetMethodID(global::android.text.style.AbsoluteSizeSpan.staticClass, "getSpanTypeId", "()I"); 
			global::android.text.style.AbsoluteSizeSpan._updateDrawState7281 = @__env.GetMethodID(global::android.text.style.AbsoluteSizeSpan.staticClass, "updateDrawState", "(Landroid/text/TextPaint;)V"); 
			global::android.text.style.AbsoluteSizeSpan._getDip7282 = @__env.GetMethodID(global::android.text.style.AbsoluteSizeSpan.staticClass, "getDip", "()Z"); 
			global::android.text.style.AbsoluteSizeSpan._updateMeasureState7283 = @__env.GetMethodID(global::android.text.style.AbsoluteSizeSpan.staticClass, "updateMeasureState", "(Landroid/text/TextPaint;)V"); 
			global::android.text.style.AbsoluteSizeSpan._AbsoluteSizeSpan7284 = @__env.GetMethodID(global::android.text.style.AbsoluteSizeSpan.staticClass, "<init>", "(I)V"); 
			global::android.text.style.AbsoluteSizeSpan._AbsoluteSizeSpan7285 = @__env.GetMethodID(global::android.text.style.AbsoluteSizeSpan.staticClass, "<init>", "(IZ)V"); 
			global::android.text.style.AbsoluteSizeSpan._AbsoluteSizeSpan7286 = @__env.GetMethodID(global::android.text.style.AbsoluteSizeSpan.staticClass, "<init>", "(Landroid/os/Parcel;)V"); 
		} 
	} 
} 
