namespace android.widget
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class ArrayAdapter : android.widget.BaseAdapter, Filterable
	{
		internal new static global::java.lang.Class staticClass;
		static ArrayAdapter()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.widget.ArrayAdapter), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.widget.ArrayAdapter(@__env);
			}
		}
		protected ArrayAdapter(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _add10561;
		public virtual void add(java.lang.Object arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.ArrayAdapter._add10561, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.ArrayAdapter.staticClass, global::android.widget.ArrayAdapter._add10561, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _clear10562;
		public virtual void clear() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.ArrayAdapter._clear10562);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.ArrayAdapter.staticClass, global::android.widget.ArrayAdapter._clear10562);
		}
		internal static global::net.sf.jni4net.jni.MethodId _remove10563;
		public virtual void remove(java.lang.Object arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.ArrayAdapter._remove10563, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.ArrayAdapter.staticClass, global::android.widget.ArrayAdapter._remove10563, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getContext10564;
		public virtual global::android.content.Context getContext() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.Context>(@__env, @__env.CallObjectMethodPtr(this, global::android.widget.ArrayAdapter._getContext10564));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.Context>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.widget.ArrayAdapter.staticClass, global::android.widget.ArrayAdapter._getContext10564));
		}
		internal static global::net.sf.jni4net.jni.MethodId _insert10565;
		public virtual void insert(java.lang.Object arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.ArrayAdapter._insert10565, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.ArrayAdapter.staticClass, global::android.widget.ArrayAdapter._insert10565, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _sort10566;
		public virtual void sort(java.util.Comparator arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.ArrayAdapter._sort10566, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.ArrayAdapter.staticClass, global::android.widget.ArrayAdapter._sort10566, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getPosition10567;
		public virtual int getPosition(java.lang.Object arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.widget.ArrayAdapter._getPosition10567, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.widget.ArrayAdapter.staticClass, global::android.widget.ArrayAdapter._getPosition10567, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getCount10568;
		public override int getCount() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.widget.ArrayAdapter._getCount10568);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.widget.ArrayAdapter.staticClass, global::android.widget.ArrayAdapter._getCount10568);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getItem10569;
		public override global::java.lang.Object getItem(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallObjectMethodPtr(this, global::android.widget.ArrayAdapter._getItem10569, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.widget.ArrayAdapter.staticClass, global::android.widget.ArrayAdapter._getItem10569, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getItemId10570;
		public override long getItemId(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this, global::android.widget.ArrayAdapter._getItemId10570, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualLongMethod(this, global::android.widget.ArrayAdapter.staticClass, global::android.widget.ArrayAdapter._getItemId10570, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getFilter10571;
		public virtual global::android.widget.Filter getFilter() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.widget.Filter>(@__env, @__env.CallObjectMethodPtr(this, global::android.widget.ArrayAdapter._getFilter10571));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.widget.Filter>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.widget.ArrayAdapter.staticClass, global::android.widget.ArrayAdapter._getFilter10571));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getView10572;
		public override global::android.view.View getView(int arg0, android.view.View arg1, android.view.ViewGroup arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallObjectMethodPtr(this, global::android.widget.ArrayAdapter._getView10572, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.widget.ArrayAdapter.staticClass, global::android.widget.ArrayAdapter._getView10572, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getDropDownView10573;
		public override global::android.view.View getDropDownView(int arg0, android.view.View arg1, android.view.ViewGroup arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallObjectMethodPtr(this, global::android.widget.ArrayAdapter._getDropDownView10573, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.widget.ArrayAdapter.staticClass, global::android.widget.ArrayAdapter._getDropDownView10573, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _notifyDataSetChanged10574;
		public override void notifyDataSetChanged() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.ArrayAdapter._notifyDataSetChanged10574);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.ArrayAdapter.staticClass, global::android.widget.ArrayAdapter._notifyDataSetChanged10574);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setNotifyOnChange10575;
		public virtual void setNotifyOnChange(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.ArrayAdapter._setNotifyOnChange10575, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.ArrayAdapter.staticClass, global::android.widget.ArrayAdapter._setNotifyOnChange10575, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setDropDownViewResource10576;
		public virtual void setDropDownViewResource(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.ArrayAdapter._setDropDownViewResource10576, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.ArrayAdapter.staticClass, global::android.widget.ArrayAdapter._setDropDownViewResource10576, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _createFromResource10577;
		public static global::android.widget.ArrayAdapter createFromResource(android.content.Context arg0, int arg1, int arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.widget.ArrayAdapter>(@__env, @__env.CallStaticObjectMethodPtr(android.widget.ArrayAdapter.staticClass, global::android.widget.ArrayAdapter._createFromResource10577, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _ArrayAdapter10578;
		public ArrayAdapter(android.content.Context arg0, int arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.widget.ArrayAdapter.staticClass, global::android.widget.ArrayAdapter._ArrayAdapter10578, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _ArrayAdapter10579;
		public ArrayAdapter(android.content.Context arg0, int arg1, int arg2)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.widget.ArrayAdapter.staticClass, global::android.widget.ArrayAdapter._ArrayAdapter10579, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _ArrayAdapter10580;
		public ArrayAdapter(android.content.Context arg0, int arg1, java.lang.Object[] arg2)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.widget.ArrayAdapter.staticClass, global::android.widget.ArrayAdapter._ArrayAdapter10580, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParArrayFullC2J<java.lang.Object[], java.lang.Object>(@__env, arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _ArrayAdapter10581;
		public ArrayAdapter(android.content.Context arg0, int arg1, int arg2, java.lang.Object[] arg3)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.widget.ArrayAdapter.staticClass, global::android.widget.ArrayAdapter._ArrayAdapter10581, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParArrayFullC2J<java.lang.Object[], java.lang.Object>(@__env, arg3));
		}
		internal static global::net.sf.jni4net.jni.MethodId _ArrayAdapter10582;
		public ArrayAdapter(android.content.Context arg0, int arg1, java.util.List arg2)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.widget.ArrayAdapter.staticClass, global::android.widget.ArrayAdapter._ArrayAdapter10582, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _ArrayAdapter10583;
		public ArrayAdapter(android.content.Context arg0, int arg1, int arg2, java.util.List arg3)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.widget.ArrayAdapter.staticClass, global::android.widget.ArrayAdapter._ArrayAdapter10583, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg3));
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.widget.ArrayAdapter.staticClass = @__class;
			global::android.widget.ArrayAdapter._add10561 = @__env.GetMethodID(global::android.widget.ArrayAdapter.staticClass, "add", "(Ljava/lang/Object;)V");
			global::android.widget.ArrayAdapter._clear10562 = @__env.GetMethodID(global::android.widget.ArrayAdapter.staticClass, "clear", "()V");
			global::android.widget.ArrayAdapter._remove10563 = @__env.GetMethodID(global::android.widget.ArrayAdapter.staticClass, "remove", "(Ljava/lang/Object;)V");
			global::android.widget.ArrayAdapter._getContext10564 = @__env.GetMethodID(global::android.widget.ArrayAdapter.staticClass, "getContext", "()Landroid/content/Context;");
			global::android.widget.ArrayAdapter._insert10565 = @__env.GetMethodID(global::android.widget.ArrayAdapter.staticClass, "insert", "(Ljava/lang/Object;I)V");
			global::android.widget.ArrayAdapter._sort10566 = @__env.GetMethodID(global::android.widget.ArrayAdapter.staticClass, "sort", "(Ljava/util/Comparator;)V");
			global::android.widget.ArrayAdapter._getPosition10567 = @__env.GetMethodID(global::android.widget.ArrayAdapter.staticClass, "getPosition", "(Ljava/lang/Object;)I");
			global::android.widget.ArrayAdapter._getCount10568 = @__env.GetMethodID(global::android.widget.ArrayAdapter.staticClass, "getCount", "()I");
			global::android.widget.ArrayAdapter._getItem10569 = @__env.GetMethodID(global::android.widget.ArrayAdapter.staticClass, "getItem", "(I)Ljava/lang/Object;");
			global::android.widget.ArrayAdapter._getItemId10570 = @__env.GetMethodID(global::android.widget.ArrayAdapter.staticClass, "getItemId", "(I)J");
			global::android.widget.ArrayAdapter._getFilter10571 = @__env.GetMethodID(global::android.widget.ArrayAdapter.staticClass, "getFilter", "()Landroid/widget/Filter;");
			global::android.widget.ArrayAdapter._getView10572 = @__env.GetMethodID(global::android.widget.ArrayAdapter.staticClass, "getView", "(ILandroid/view/View;Landroid/view/ViewGroup;)Landroid/view/View;");
			global::android.widget.ArrayAdapter._getDropDownView10573 = @__env.GetMethodID(global::android.widget.ArrayAdapter.staticClass, "getDropDownView", "(ILandroid/view/View;Landroid/view/ViewGroup;)Landroid/view/View;");
			global::android.widget.ArrayAdapter._notifyDataSetChanged10574 = @__env.GetMethodID(global::android.widget.ArrayAdapter.staticClass, "notifyDataSetChanged", "()V");
			global::android.widget.ArrayAdapter._setNotifyOnChange10575 = @__env.GetMethodID(global::android.widget.ArrayAdapter.staticClass, "setNotifyOnChange", "(Z)V");
			global::android.widget.ArrayAdapter._setDropDownViewResource10576 = @__env.GetMethodID(global::android.widget.ArrayAdapter.staticClass, "setDropDownViewResource", "(I)V");
			global::android.widget.ArrayAdapter._createFromResource10577 = @__env.GetStaticMethodID(global::android.widget.ArrayAdapter.staticClass, "createFromResource", "(Landroid/content/Context;II)Landroid/widget/ArrayAdapter;");
			global::android.widget.ArrayAdapter._ArrayAdapter10578 = @__env.GetMethodID(global::android.widget.ArrayAdapter.staticClass, "<init>", "(Landroid/content/Context;I)V");
			global::android.widget.ArrayAdapter._ArrayAdapter10579 = @__env.GetMethodID(global::android.widget.ArrayAdapter.staticClass, "<init>", "(Landroid/content/Context;II)V");
			global::android.widget.ArrayAdapter._ArrayAdapter10580 = @__env.GetMethodID(global::android.widget.ArrayAdapter.staticClass, "<init>", "(Landroid/content/Context;I[Ljava/lang/Object;)V");
			global::android.widget.ArrayAdapter._ArrayAdapter10581 = @__env.GetMethodID(global::android.widget.ArrayAdapter.staticClass, "<init>", "(Landroid/content/Context;II[Ljava/lang/Object;)V");
			global::android.widget.ArrayAdapter._ArrayAdapter10582 = @__env.GetMethodID(global::android.widget.ArrayAdapter.staticClass, "<init>", "(Landroid/content/Context;ILjava/util/List;)V");
			global::android.widget.ArrayAdapter._ArrayAdapter10583 = @__env.GetMethodID(global::android.widget.ArrayAdapter.staticClass, "<init>", "(Landroid/content/Context;IILjava/util/List;)V");
		}
	}
}
