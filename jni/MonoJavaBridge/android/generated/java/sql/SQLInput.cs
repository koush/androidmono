namespace java.sql
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::java.sql.SQLInput_))]
	public interface SQLInput  : global::MonoJavaBridge.IJavaObject 
	{
		global::java.lang.Object readObject();
		int readInt();
		byte[] readBytes();
		long readLong();
		byte readByte();
		short readShort();
		float readFloat();
		bool readBoolean();
		double readDouble();
		global::java.lang.String readString();
		global::java.sql.Array readArray();
		bool wasNull();
		global::java.math.BigDecimal readBigDecimal();
		global::java.sql.Date readDate();
		global::java.sql.Time readTime();
		global::java.sql.Timestamp readTimestamp();
		global::java.io.Reader readCharacterStream();
		global::java.io.InputStream readAsciiStream();
		global::java.io.InputStream readBinaryStream();
		global::java.sql.Ref readRef();
		global::java.sql.Blob readBlob();
		global::java.sql.Clob readClob();
		global::java.net.URL readURL();
		global::java.lang.String readNString();
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.sql.SQLInput))]
	public sealed partial class SQLInput_ : java.lang.Object, SQLInput
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static SQLInput_()
		{
			InitJNI();
		}
		internal SQLInput_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _readObject19169;
		 global::java.lang.Object java.sql.SQLInput.readObject() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.SQLInput_._readObject19169)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.SQLInput_.staticClass, global::java.sql.SQLInput_._readObject19169)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _readInt19170;
		 int java.sql.SQLInput.readInt() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.sql.SQLInput_._readInt19170);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.sql.SQLInput_.staticClass, global::java.sql.SQLInput_._readInt19170);
		}
		internal static global::MonoJavaBridge.MethodId _readBytes19171;
		 byte[] java.sql.SQLInput.readBytes() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.SQLInput_._readBytes19171)) as byte[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.SQLInput_.staticClass, global::java.sql.SQLInput_._readBytes19171)) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _readLong19172;
		 long java.sql.SQLInput.readLong() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.sql.SQLInput_._readLong19172);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.sql.SQLInput_.staticClass, global::java.sql.SQLInput_._readLong19172);
		}
		internal static global::MonoJavaBridge.MethodId _readByte19173;
		 byte java.sql.SQLInput.readByte() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallByteMethod(this.JvmHandle, global::java.sql.SQLInput_._readByte19173);
			else
				return @__env.CallNonVirtualByteMethod(this.JvmHandle, global::java.sql.SQLInput_.staticClass, global::java.sql.SQLInput_._readByte19173);
		}
		internal static global::MonoJavaBridge.MethodId _readShort19174;
		 short java.sql.SQLInput.readShort() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallShortMethod(this.JvmHandle, global::java.sql.SQLInput_._readShort19174);
			else
				return @__env.CallNonVirtualShortMethod(this.JvmHandle, global::java.sql.SQLInput_.staticClass, global::java.sql.SQLInput_._readShort19174);
		}
		internal static global::MonoJavaBridge.MethodId _readFloat19175;
		 float java.sql.SQLInput.readFloat() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::java.sql.SQLInput_._readFloat19175);
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::java.sql.SQLInput_.staticClass, global::java.sql.SQLInput_._readFloat19175);
		}
		internal static global::MonoJavaBridge.MethodId _readBoolean19176;
		 bool java.sql.SQLInput.readBoolean() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.SQLInput_._readBoolean19176);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.SQLInput_.staticClass, global::java.sql.SQLInput_._readBoolean19176);
		}
		internal static global::MonoJavaBridge.MethodId _readDouble19177;
		 double java.sql.SQLInput.readDouble() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallDoubleMethod(this.JvmHandle, global::java.sql.SQLInput_._readDouble19177);
			else
				return @__env.CallNonVirtualDoubleMethod(this.JvmHandle, global::java.sql.SQLInput_.staticClass, global::java.sql.SQLInput_._readDouble19177);
		}
		internal static global::MonoJavaBridge.MethodId _readString19178;
		 global::java.lang.String java.sql.SQLInput.readString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.SQLInput_._readString19178)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.SQLInput_.staticClass, global::java.sql.SQLInput_._readString19178)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _readArray19179;
		 global::java.sql.Array java.sql.SQLInput.readArray() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.Array>(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.SQLInput_._readArray19179)) as java.sql.Array;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.Array>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.SQLInput_.staticClass, global::java.sql.SQLInput_._readArray19179)) as java.sql.Array;
		}
		internal static global::MonoJavaBridge.MethodId _wasNull19180;
		 bool java.sql.SQLInput.wasNull() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.SQLInput_._wasNull19180);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.SQLInput_.staticClass, global::java.sql.SQLInput_._wasNull19180);
		}
		internal static global::MonoJavaBridge.MethodId _readBigDecimal19181;
		 global::java.math.BigDecimal java.sql.SQLInput.readBigDecimal() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.SQLInput_._readBigDecimal19181)) as java.math.BigDecimal;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.SQLInput_.staticClass, global::java.sql.SQLInput_._readBigDecimal19181)) as java.math.BigDecimal;
		}
		internal static global::MonoJavaBridge.MethodId _readDate19182;
		 global::java.sql.Date java.sql.SQLInput.readDate() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.SQLInput_._readDate19182)) as java.sql.Date;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.SQLInput_.staticClass, global::java.sql.SQLInput_._readDate19182)) as java.sql.Date;
		}
		internal static global::MonoJavaBridge.MethodId _readTime19183;
		 global::java.sql.Time java.sql.SQLInput.readTime() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.SQLInput_._readTime19183)) as java.sql.Time;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.SQLInput_.staticClass, global::java.sql.SQLInput_._readTime19183)) as java.sql.Time;
		}
		internal static global::MonoJavaBridge.MethodId _readTimestamp19184;
		 global::java.sql.Timestamp java.sql.SQLInput.readTimestamp() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.SQLInput_._readTimestamp19184)) as java.sql.Timestamp;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.SQLInput_.staticClass, global::java.sql.SQLInput_._readTimestamp19184)) as java.sql.Timestamp;
		}
		internal static global::MonoJavaBridge.MethodId _readCharacterStream19185;
		 global::java.io.Reader java.sql.SQLInput.readCharacterStream() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.SQLInput_._readCharacterStream19185)) as java.io.Reader;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.SQLInput_.staticClass, global::java.sql.SQLInput_._readCharacterStream19185)) as java.io.Reader;
		}
		internal static global::MonoJavaBridge.MethodId _readAsciiStream19186;
		 global::java.io.InputStream java.sql.SQLInput.readAsciiStream() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.SQLInput_._readAsciiStream19186)) as java.io.InputStream;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.SQLInput_.staticClass, global::java.sql.SQLInput_._readAsciiStream19186)) as java.io.InputStream;
		}
		internal static global::MonoJavaBridge.MethodId _readBinaryStream19187;
		 global::java.io.InputStream java.sql.SQLInput.readBinaryStream() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.SQLInput_._readBinaryStream19187)) as java.io.InputStream;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.SQLInput_.staticClass, global::java.sql.SQLInput_._readBinaryStream19187)) as java.io.InputStream;
		}
		internal static global::MonoJavaBridge.MethodId _readRef19188;
		 global::java.sql.Ref java.sql.SQLInput.readRef() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.Ref>(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.SQLInput_._readRef19188)) as java.sql.Ref;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.Ref>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.SQLInput_.staticClass, global::java.sql.SQLInput_._readRef19188)) as java.sql.Ref;
		}
		internal static global::MonoJavaBridge.MethodId _readBlob19189;
		 global::java.sql.Blob java.sql.SQLInput.readBlob() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.Blob>(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.SQLInput_._readBlob19189)) as java.sql.Blob;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.Blob>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.SQLInput_.staticClass, global::java.sql.SQLInput_._readBlob19189)) as java.sql.Blob;
		}
		internal static global::MonoJavaBridge.MethodId _readClob19190;
		 global::java.sql.Clob java.sql.SQLInput.readClob() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.Clob>(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.SQLInput_._readClob19190)) as java.sql.Clob;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.Clob>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.SQLInput_.staticClass, global::java.sql.SQLInput_._readClob19190)) as java.sql.Clob;
		}
		internal static global::MonoJavaBridge.MethodId _readURL19191;
		 global::java.net.URL java.sql.SQLInput.readURL() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.SQLInput_._readURL19191)) as java.net.URL;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.SQLInput_.staticClass, global::java.sql.SQLInput_._readURL19191)) as java.net.URL;
		}
		internal static global::MonoJavaBridge.MethodId _readNString19192;
		 global::java.lang.String java.sql.SQLInput.readNString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.SQLInput_._readNString19192)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.SQLInput_.staticClass, global::java.sql.SQLInput_._readNString19192)) as java.lang.String;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.sql.SQLInput_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/sql/SQLInput"));
			global::java.sql.SQLInput_._readObject19169 = @__env.GetMethodIDNoThrow(global::java.sql.SQLInput_.staticClass, "readObject", "()Ljava/lang/Object;");
			global::java.sql.SQLInput_._readInt19170 = @__env.GetMethodIDNoThrow(global::java.sql.SQLInput_.staticClass, "readInt", "()I");
			global::java.sql.SQLInput_._readBytes19171 = @__env.GetMethodIDNoThrow(global::java.sql.SQLInput_.staticClass, "readBytes", "()[B");
			global::java.sql.SQLInput_._readLong19172 = @__env.GetMethodIDNoThrow(global::java.sql.SQLInput_.staticClass, "readLong", "()J");
			global::java.sql.SQLInput_._readByte19173 = @__env.GetMethodIDNoThrow(global::java.sql.SQLInput_.staticClass, "readByte", "()B");
			global::java.sql.SQLInput_._readShort19174 = @__env.GetMethodIDNoThrow(global::java.sql.SQLInput_.staticClass, "readShort", "()S");
			global::java.sql.SQLInput_._readFloat19175 = @__env.GetMethodIDNoThrow(global::java.sql.SQLInput_.staticClass, "readFloat", "()F");
			global::java.sql.SQLInput_._readBoolean19176 = @__env.GetMethodIDNoThrow(global::java.sql.SQLInput_.staticClass, "readBoolean", "()Z");
			global::java.sql.SQLInput_._readDouble19177 = @__env.GetMethodIDNoThrow(global::java.sql.SQLInput_.staticClass, "readDouble", "()D");
			global::java.sql.SQLInput_._readString19178 = @__env.GetMethodIDNoThrow(global::java.sql.SQLInput_.staticClass, "readString", "()Ljava/lang/String;");
			global::java.sql.SQLInput_._readArray19179 = @__env.GetMethodIDNoThrow(global::java.sql.SQLInput_.staticClass, "readArray", "()Ljava/sql/Array;");
			global::java.sql.SQLInput_._wasNull19180 = @__env.GetMethodIDNoThrow(global::java.sql.SQLInput_.staticClass, "wasNull", "()Z");
			global::java.sql.SQLInput_._readBigDecimal19181 = @__env.GetMethodIDNoThrow(global::java.sql.SQLInput_.staticClass, "readBigDecimal", "()Ljava/math/BigDecimal;");
			global::java.sql.SQLInput_._readDate19182 = @__env.GetMethodIDNoThrow(global::java.sql.SQLInput_.staticClass, "readDate", "()Ljava/sql/Date;");
			global::java.sql.SQLInput_._readTime19183 = @__env.GetMethodIDNoThrow(global::java.sql.SQLInput_.staticClass, "readTime", "()Ljava/sql/Time;");
			global::java.sql.SQLInput_._readTimestamp19184 = @__env.GetMethodIDNoThrow(global::java.sql.SQLInput_.staticClass, "readTimestamp", "()Ljava/sql/Timestamp;");
			global::java.sql.SQLInput_._readCharacterStream19185 = @__env.GetMethodIDNoThrow(global::java.sql.SQLInput_.staticClass, "readCharacterStream", "()Ljava/io/Reader;");
			global::java.sql.SQLInput_._readAsciiStream19186 = @__env.GetMethodIDNoThrow(global::java.sql.SQLInput_.staticClass, "readAsciiStream", "()Ljava/io/InputStream;");
			global::java.sql.SQLInput_._readBinaryStream19187 = @__env.GetMethodIDNoThrow(global::java.sql.SQLInput_.staticClass, "readBinaryStream", "()Ljava/io/InputStream;");
			global::java.sql.SQLInput_._readRef19188 = @__env.GetMethodIDNoThrow(global::java.sql.SQLInput_.staticClass, "readRef", "()Ljava/sql/Ref;");
			global::java.sql.SQLInput_._readBlob19189 = @__env.GetMethodIDNoThrow(global::java.sql.SQLInput_.staticClass, "readBlob", "()Ljava/sql/Blob;");
			global::java.sql.SQLInput_._readClob19190 = @__env.GetMethodIDNoThrow(global::java.sql.SQLInput_.staticClass, "readClob", "()Ljava/sql/Clob;");
			global::java.sql.SQLInput_._readURL19191 = @__env.GetMethodIDNoThrow(global::java.sql.SQLInput_.staticClass, "readURL", "()Ljava/net/URL;");
			global::java.sql.SQLInput_._readNString19192 = @__env.GetMethodIDNoThrow(global::java.sql.SQLInput_.staticClass, "readNString", "()Ljava/lang/String;");
		}
	}
}
