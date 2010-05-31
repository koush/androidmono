namespace android.widget
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class AlphabetIndexer : android.database.DataSetObserver, SectionIndexer
	{
		internal new static global::java.lang.Class staticClass;
		static AlphabetIndexer()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.widget.AlphabetIndexer), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.widget.AlphabetIndexer(@__env);
			}
		}
		protected AlphabetIndexer(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _compare9848;
		protected virtual int compare(java.lang.String arg0, java.lang.String arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.widget.AlphabetIndexer._compare9848, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.widget.AlphabetIndexer.staticClass, global::android.widget.AlphabetIndexer._compare9848, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setCursor9849;
		public virtual void setCursor(android.database.Cursor arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.AlphabetIndexer._setCursor9849, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.AlphabetIndexer.staticClass, global::android.widget.AlphabetIndexer._setCursor9849, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onChanged9850;
		public override void onChanged() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.AlphabetIndexer._onChanged9850);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.AlphabetIndexer.staticClass, global::android.widget.AlphabetIndexer._onChanged9850);
		}
		internal static global::net.sf.jni4net.jni.MethodId _onInvalidated9851;
		public override void onInvalidated() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.AlphabetIndexer._onInvalidated9851);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.AlphabetIndexer.staticClass, global::android.widget.AlphabetIndexer._onInvalidated9851);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getSections9852;
		public virtual global::java.lang.Object[] getSections() 
		{
			if (!IsClrObject)
				return null;//(@__env, @__env.CallObjectMethodPtr(this, global::android.widget.AlphabetIndexer._getSections9852));
			else
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.widget.AlphabetIndexer.staticClass, global::android.widget.AlphabetIndexer._getSections9852));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getPositionForSection9853;
		public virtual int getPositionForSection(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.widget.AlphabetIndexer._getPositionForSection9853, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.widget.AlphabetIndexer.staticClass, global::android.widget.AlphabetIndexer._getPositionForSection9853, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getSectionForPosition9854;
		public virtual int getSectionForPosition(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.widget.AlphabetIndexer._getSectionForPosition9854, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.widget.AlphabetIndexer.staticClass, global::android.widget.AlphabetIndexer._getSectionForPosition9854, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _AlphabetIndexer9855;
		public AlphabetIndexer(android.database.Cursor arg0, int arg1, java.lang.CharSequence arg2)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.widget.AlphabetIndexer.staticClass, global::android.widget.AlphabetIndexer._AlphabetIndexer9855, this, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2));
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.widget.AlphabetIndexer.staticClass = @__class;
			global::android.widget.AlphabetIndexer._compare9848 = @__env.GetMethodID(global::android.widget.AlphabetIndexer.staticClass, "compare", "(Ljava/lang/String;Ljava/lang/String;)I");
			global::android.widget.AlphabetIndexer._setCursor9849 = @__env.GetMethodID(global::android.widget.AlphabetIndexer.staticClass, "setCursor", "(Landroid/database/Cursor;)V");
			global::android.widget.AlphabetIndexer._onChanged9850 = @__env.GetMethodID(global::android.widget.AlphabetIndexer.staticClass, "onChanged", "()V");
			global::android.widget.AlphabetIndexer._onInvalidated9851 = @__env.GetMethodID(global::android.widget.AlphabetIndexer.staticClass, "onInvalidated", "()V");
			global::android.widget.AlphabetIndexer._getSections9852 = @__env.GetMethodID(global::android.widget.AlphabetIndexer.staticClass, "getSections", "()[Ljava/lang/Object;");
			global::android.widget.AlphabetIndexer._getPositionForSection9853 = @__env.GetMethodID(global::android.widget.AlphabetIndexer.staticClass, "getPositionForSection", "(I)I");
			global::android.widget.AlphabetIndexer._getSectionForPosition9854 = @__env.GetMethodID(global::android.widget.AlphabetIndexer.staticClass, "getSectionForPosition", "(I)I");
			global::android.widget.AlphabetIndexer._AlphabetIndexer9855 = @__env.GetMethodID(global::android.widget.AlphabetIndexer.staticClass, "<init>", "(Landroid/database/Cursor;ILjava/lang/CharSequence;)V");
		}
	}
}
