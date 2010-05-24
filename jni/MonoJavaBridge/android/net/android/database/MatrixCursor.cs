namespace android.database 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class MatrixCursor : android.database.AbstractCursor
	{ 
		internal new static global::java.lang.Class staticClass; 
		static MatrixCursor() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.database.MatrixCursor), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.database.MatrixCursor(@__env); 
			} 
		} 
		protected MatrixCursor(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
		public class RowBuilder : java.lang.Object
		{ 
			internal static global::java.lang.Class staticClass; 
			static RowBuilder() 
			{ 
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.database.MatrixCursor.RowBuilder), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
			} 
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
			{ 
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
				{ 
					return new global::android.database.MatrixCursor.RowBuilder(@__env); 
				} 
			} 
			protected RowBuilder(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
			{ 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _add2392; 
			public virtual android.database.MatrixCursor.RowBuilder add(java.lang.Object arg0) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.database.MatrixCursor.RowBuilder)) 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.database.MatrixCursor.RowBuilder>(@__env, @__env.CallObjectMethodPtr(this, _add2392, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0))); 
				else 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.database.MatrixCursor.RowBuilder>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.database.MatrixCursor.RowBuilder.staticClass, _add2392, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0))); 
			} 
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
			{ 
				global::android.database.MatrixCursor.RowBuilder.staticClass = @__class; 
				global::android.database.MatrixCursor.RowBuilder._add2392 = @__env.GetMethodID(global::android.database.MatrixCursor.RowBuilder.staticClass, "add", "(Ljava/lang/Object;)Landroid/database/MatrixCursor$RowBuilder;"); 
			} 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getShort2393; 
		public override short getShort(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.MatrixCursor)) 
				return @__env.CallShortMethod(this, _getShort2393, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualShortMethod(this, android.database.MatrixCursor.staticClass, _getShort2393, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getInt2394; 
		public override int getInt(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.MatrixCursor)) 
				return @__env.CallIntMethod(this, _getInt2394, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.database.MatrixCursor.staticClass, _getInt2394, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getLong2395; 
		public override long getLong(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.MatrixCursor)) 
				return @__env.CallLongMethod(this, _getLong2395, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualLongMethod(this, android.database.MatrixCursor.staticClass, _getLong2395, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getFloat2396; 
		public override float getFloat(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.MatrixCursor)) 
				return @__env.CallFloatMethod(this, _getFloat2396, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualFloatMethod(this, android.database.MatrixCursor.staticClass, _getFloat2396, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getDouble2397; 
		public override double getDouble(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.MatrixCursor)) 
				return @__env.CallDoubleMethod(this, _getDouble2397, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualDoubleMethod(this, android.database.MatrixCursor.staticClass, _getDouble2397, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getString2398; 
		public override java.lang.String getString(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.MatrixCursor)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _getString2398, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.database.MatrixCursor.staticClass, _getString2398, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getCount2399; 
		public override int getCount() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.MatrixCursor)) 
				return @__env.CallIntMethod(this, _getCount2399); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.database.MatrixCursor.staticClass, _getCount2399); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getColumnNames2400; 
		public override java.lang.String[] getColumnNames() 
		{ 
			if (GetType() == typeof(android.database.MatrixCursor)) 
				return null;//(@__env, @__env.CallObjectMethodPtr(this, _getColumnNames2400)); 
			else 
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.database.MatrixCursor.staticClass, _getColumnNames2400)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isNull2401; 
		public override bool isNull(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.MatrixCursor)) 
				return @__env.CallBooleanMethod(this, _isNull2401, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.database.MatrixCursor.staticClass, _isNull2401, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _newRow2402; 
		public virtual android.database.MatrixCursor.RowBuilder newRow() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.MatrixCursor)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.database.MatrixCursor.RowBuilder>(@__env, @__env.CallObjectMethodPtr(this, _newRow2402)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.database.MatrixCursor.RowBuilder>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.database.MatrixCursor.staticClass, _newRow2402)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _addRow2403; 
		public virtual void addRow(java.lang.Iterable arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.MatrixCursor)) 
				@__env.CallVoidMethod(this, _addRow2403, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.database.MatrixCursor.staticClass, _addRow2403, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _addRow2404; 
		public virtual void addRow(java.lang.Object[] arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.MatrixCursor)) 
				@__env.CallVoidMethod(this, _addRow2404, global::net.sf.jni4net.utils.Convertor.ParArrayFullC2J<java.lang.Object[], java.lang.Object>(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.database.MatrixCursor.staticClass, _addRow2404, global::net.sf.jni4net.utils.Convertor.ParArrayFullC2J<java.lang.Object[], java.lang.Object>(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _MatrixCursor2405; 
		public MatrixCursor(java.lang.String[] arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.database.MatrixCursor.staticClass, _MatrixCursor2405, this, global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _MatrixCursor2406; 
		public MatrixCursor(java.lang.String[] arg0, int arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.database.MatrixCursor.staticClass, _MatrixCursor2406, this, global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.database.MatrixCursor.staticClass = @__class; 
			global::android.database.MatrixCursor._getShort2393 = @__env.GetMethodID(global::android.database.MatrixCursor.staticClass, "getShort", "(I)S"); 
			global::android.database.MatrixCursor._getInt2394 = @__env.GetMethodID(global::android.database.MatrixCursor.staticClass, "getInt", "(I)I"); 
			global::android.database.MatrixCursor._getLong2395 = @__env.GetMethodID(global::android.database.MatrixCursor.staticClass, "getLong", "(I)J"); 
			global::android.database.MatrixCursor._getFloat2396 = @__env.GetMethodID(global::android.database.MatrixCursor.staticClass, "getFloat", "(I)F"); 
			global::android.database.MatrixCursor._getDouble2397 = @__env.GetMethodID(global::android.database.MatrixCursor.staticClass, "getDouble", "(I)D"); 
			global::android.database.MatrixCursor._getString2398 = @__env.GetMethodID(global::android.database.MatrixCursor.staticClass, "getString", "(I)Ljava/lang/String;"); 
			global::android.database.MatrixCursor._getCount2399 = @__env.GetMethodID(global::android.database.MatrixCursor.staticClass, "getCount", "()I"); 
			global::android.database.MatrixCursor._getColumnNames2400 = @__env.GetMethodID(global::android.database.MatrixCursor.staticClass, "getColumnNames", "()[Ljava/lang/String;"); 
			global::android.database.MatrixCursor._isNull2401 = @__env.GetMethodID(global::android.database.MatrixCursor.staticClass, "isNull", "(I)Z"); 
			global::android.database.MatrixCursor._newRow2402 = @__env.GetMethodID(global::android.database.MatrixCursor.staticClass, "newRow", "()Landroid/database/MatrixCursor$RowBuilder;"); 
			global::android.database.MatrixCursor._addRow2403 = @__env.GetMethodID(global::android.database.MatrixCursor.staticClass, "addRow", "(Ljava/lang/Iterable;)V"); 
			global::android.database.MatrixCursor._addRow2404 = @__env.GetMethodID(global::android.database.MatrixCursor.staticClass, "addRow", "([Ljava/lang/Object;)V"); 
			global::android.database.MatrixCursor._MatrixCursor2405 = @__env.GetMethodID(global::android.database.MatrixCursor.staticClass, "<init>", "([Ljava/lang/String;)V"); 
			global::android.database.MatrixCursor._MatrixCursor2406 = @__env.GetMethodID(global::android.database.MatrixCursor.staticClass, "<init>", "([Ljava/lang/String;I)V"); 
		} 
	} 
} 
