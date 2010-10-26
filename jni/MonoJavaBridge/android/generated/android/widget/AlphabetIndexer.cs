namespace android.widget
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class AlphabetIndexer : android.database.DataSetObserver, SectionIndexer
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static AlphabetIndexer()
		{
			InitJNI();
		}
		protected AlphabetIndexer(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _compare16686;
		protected virtual int compare(java.lang.String arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.AlphabetIndexer._compare16686, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.AlphabetIndexer.staticClass, global::android.widget.AlphabetIndexer._compare16686, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setCursor16687;
		public virtual void setCursor(android.database.Cursor arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.AlphabetIndexer._setCursor16687, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.AlphabetIndexer.staticClass, global::android.widget.AlphabetIndexer._setCursor16687, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onChanged16688;
		public override void onChanged() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.AlphabetIndexer._onChanged16688);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.AlphabetIndexer.staticClass, global::android.widget.AlphabetIndexer._onChanged16688);
		}
		internal static global::MonoJavaBridge.MethodId _onInvalidated16689;
		public override void onInvalidated() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.AlphabetIndexer._onInvalidated16689);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.AlphabetIndexer.staticClass, global::android.widget.AlphabetIndexer._onInvalidated16689);
		}
		public new global::java.lang.Object[] Sections
		{
			get
			{
				return getSections();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getSections16690;
		public virtual global::java.lang.Object[] getSections() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.AlphabetIndexer._getSections16690)) as java.lang.Object[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.AlphabetIndexer.staticClass, global::android.widget.AlphabetIndexer._getSections16690)) as java.lang.Object[];
		}
		internal static global::MonoJavaBridge.MethodId _getPositionForSection16691;
		public virtual int getPositionForSection(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.AlphabetIndexer._getPositionForSection16691, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.AlphabetIndexer.staticClass, global::android.widget.AlphabetIndexer._getPositionForSection16691, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getSectionForPosition16692;
		public virtual int getSectionForPosition(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.AlphabetIndexer._getSectionForPosition16692, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.AlphabetIndexer.staticClass, global::android.widget.AlphabetIndexer._getSectionForPosition16692, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _AlphabetIndexer16693;
		public AlphabetIndexer(android.database.Cursor arg0, int arg1, java.lang.CharSequence arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.AlphabetIndexer.staticClass, global::android.widget.AlphabetIndexer._AlphabetIndexer16693, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.widget.AlphabetIndexer.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/AlphabetIndexer"));
			global::android.widget.AlphabetIndexer._compare16686 = @__env.GetMethodIDNoThrow(global::android.widget.AlphabetIndexer.staticClass, "compare", "(Ljava/lang/String;Ljava/lang/String;)I");
			global::android.widget.AlphabetIndexer._setCursor16687 = @__env.GetMethodIDNoThrow(global::android.widget.AlphabetIndexer.staticClass, "setCursor", "(Landroid/database/Cursor;)V");
			global::android.widget.AlphabetIndexer._onChanged16688 = @__env.GetMethodIDNoThrow(global::android.widget.AlphabetIndexer.staticClass, "onChanged", "()V");
			global::android.widget.AlphabetIndexer._onInvalidated16689 = @__env.GetMethodIDNoThrow(global::android.widget.AlphabetIndexer.staticClass, "onInvalidated", "()V");
			global::android.widget.AlphabetIndexer._getSections16690 = @__env.GetMethodIDNoThrow(global::android.widget.AlphabetIndexer.staticClass, "getSections", "()[Ljava/lang/Object;");
			global::android.widget.AlphabetIndexer._getPositionForSection16691 = @__env.GetMethodIDNoThrow(global::android.widget.AlphabetIndexer.staticClass, "getPositionForSection", "(I)I");
			global::android.widget.AlphabetIndexer._getSectionForPosition16692 = @__env.GetMethodIDNoThrow(global::android.widget.AlphabetIndexer.staticClass, "getSectionForPosition", "(I)I");
			global::android.widget.AlphabetIndexer._AlphabetIndexer16693 = @__env.GetMethodIDNoThrow(global::android.widget.AlphabetIndexer.staticClass, "<init>", "(Landroid/database/Cursor;ILjava/lang/CharSequence;)V");
		}
	}
}
